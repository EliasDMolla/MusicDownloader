using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace WebScrapingDesktop
{
    public partial class frmMusicDownloader : Form
    {
        public frmMusicDownloader()
        {
            InitializeComponent();
        }

        void axBrowser_NewWindow(string URL, int Flags, string TargetFrameName, ref object PostData, string Headers, ref bool Processed)
        {
            // cancel the PopUp event  
            Processed = true;

            // send the popup URL to the WebBrowser control  
            //navegador.Navigate("https://mp3xdi.org/");
        }

        WebBrowser navegador = new WebBrowser();
        private void Form1_Load_1(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/ruta.txt";
            using (StreamReader sr = new StreamReader(path, false))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    txtRutaDescarga.Text = line;
                }
            }

            if(txtRutaDescarga.Text == "")
            {
                txtRutaDescarga.Text = Application.StartupPath;
            }

            btn_nuevaBusqueda.Visible = false;

            navegador.Navigate("https://mp3xdi.org/");
            navegador.ScriptErrorsSuppressed = true;

            DataGridViewButtonColumn btnClm = new DataGridViewButtonColumn();
            btnClm.Name = "Descargar";
            btnClm.Text = "Descargar";
            grilla.Columns.Add(btnClm);

            txt_buscarCancion.Focus();
        }
        
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(txt_buscarCancion.Text != "")
            {
                // esto supone que ha agregado una instancia de WebBrowser y la ha denominado webBrowser en su formulario  
                SHDocVw.WebBrowser_V1 axBrowser = (SHDocVw.WebBrowser_V1)navegador.ActiveXInstance;

                // escuchar nuevas ventanas
                axBrowser.NewWindow += axBrowser_NewWindow;

                grilla.Rows.Clear();
                btn_nuevaBusqueda.Visible = true;

                navegador.Document.GetElementById("find_songs").SetAttribute("value", txt_buscarCancion.Text);
                navegador.Document.GetElementById("search_button").InvokeMember("click");

                navegador.DocumentCompleted += Navegador_DocumentCompleted;

                txt_buscarCancion.Enabled = false;
            }
            else
            {
                txt_buscarCancion.Focus();
            }
        }

        private void Navegador_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Metadatos md = new Metadatos();

            string[] artista = null;

            foreach (HtmlElement etiqueta in navegador.Document.All)
            {
                if (etiqueta.GetAttribute("prefixo").Contains("guardar_uno"))
                {
                    if (md.artistaCancion.Contains(','))
                    {
                        artista = md.artistaCancion.Split(',');
                    }
                    else if (md.artistaCancion.Contains('-'))
                    {
                        artista = md.artistaCancion.Split('-');
                    }

                    md.identificador = etiqueta.GetAttribute("identificador").ToString();
                    md.lesma = etiqueta.GetAttribute("lesma").ToString();
                    grilla.Rows.Add(md.identificador, md.lesma, artista[0], artista[1], md.metaDos);
                }

                if (etiqueta.TagName == "SPAN")
                {
                    if (etiqueta.GetAttribute("CLASSNAME").Contains("mp3-title"))
                    {
                        if (etiqueta.InnerText == null)
                        {
                            md.artistaCancion = "este es nulo";
                        }
                        else
                        {
                            md.artistaCancion = etiqueta.InnerText;
                        }
                    }

                    if (etiqueta.GetAttribute("CLASSNAME").Contains("mp3-url"))
                    {
                        if (etiqueta.InnerText == null)
                        {
                            md.metaDos = "este es nullo";
                        }
                        else
                        {
                            md.metaDos = etiqueta.InnerText;
                        }
                    }
                }
            }
        }

        private void cargando(object sender, DownloadProgressChangedEventArgs e) 
        {
            listaWC[0] = (MiWebClient)sender;


            this.grilla_descargas.Rows[listaWC.Count - 1].Cells[3].Value = e.ProgressPercentage;
            
            ////this.grilla_descargas.Rows[0].Cells[1].Value = wc.titulo;
            ////this.grilla_descargas.Rows[0].Cells[2].Value = wc.duracion;
            ////this.grilla_descargas.Rows[0].Cells[3].Value = wc.progreso;
        }

        private void descargado(object sender, AsyncCompletedEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);

            //MessageBox.Show("Descarga Completa!");
        }

        public class MiWebClient : WebClient
        {
            public string artista { get; set; }
            public string titulo { get; set; }
            public string duracion { get; set; }
            public int fila { get; set; }
            public int progreso { get; set; }
        }
        
        public class Metadatos
        {
            public string artistaCancion { get; set; }
            public string metaDos { get; set; }
            public string identificador { get; set; }
            public string lesma { get; set; }
        }

        List<WebClient> listaWC = new List<WebClient>();
        
        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1)
            {
                if(e.RowIndex != -1)
                {
                    if (this.grilla.Columns[e.ColumnIndex].Name == "Descargar")
                    {
                        string artista = grilla.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string titulo = grilla.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string duracion = grilla.Rows[e.RowIndex].Cells[4].Value.ToString();

                        string urlParte1 = grilla.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string urlParte2 = grilla.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string urlLista = "https://y.mp3xdi.org/yd/" + urlParte1 + "/" + urlParte2 + ".mp3";

                        string link = urlLista;

                        Uri realLink = new Uri(link);

                        MiWebClient wc = new MiWebClient();
                        listaWC.Add(wc);

                        wc.artista = artista;
                        wc.titulo = titulo;
                        wc.duracion = duracion;
                        wc.fila = listaWC.Count - 1;

                        if (txtRutaDescarga.Text != "")
                        {
                            wc.DownloadFileAsync(new Uri(link), txtRutaDescarga.Text + "/" + artista + "-" + titulo + ".mp3");
                        }
                        else
                        {
                            string path = Application.StartupPath;

                            wc.DownloadFileAsync(new Uri(link), path + "/" + artista + "-" + titulo + ".mp3");
                        }

                        //wc.progreso += new DownloadProgressChangedEventHandler(cargando);
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(cargando);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(descargado);

                        grilla_descargas.Rows.Add(wc.artista, titulo, wc.duracion);
                    }
                }
            }
        }

        private void btnSeleccionarRuta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            folderBrowser.SelectedPath = txtRutaDescarga.Text;
            folderBrowser.ShowNewFolderButton = true;
            folderBrowser.Description = "Selecciona la carpeta";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string path = Application.StartupPath + "/ruta.txt";
                string texto = folderBrowser.SelectedPath;

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(texto);
                }

                txtRutaDescarga.Text = folderBrowser.SelectedPath;
            }
        }

        private void btn_nuevaBusqueda_Click(object sender, EventArgs e)
        {
            txt_buscarCancion.Enabled = true;
            btn_nuevaBusqueda.Visible = false;
            txt_buscarCancion.Focus();
            txt_buscarCancion.Text = null;
        }

        private void txt_buscarCancion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_buscar.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
