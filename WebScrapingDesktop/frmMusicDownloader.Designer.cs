namespace WebScrapingDesktop
{
    partial class frmMusicDownloader
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusicDownloader));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grilla_descargas = new System.Windows.Forms.DataGridView();
            this.asd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRutaDescarga = new System.Windows.Forms.TextBox();
            this.btnSeleccionarRuta = new System.Windows.Forms.LinkLabel();
            this.btn_nuevaBusqueda = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscarCancion = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_descargas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Descarga finalizada";
            this.notifyIcon1.BalloonTipTitle = "Music Downloader";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grilla_descargas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descargas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grilla_descargas
            // 
            this.grilla_descargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_descargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asd,
            this.Column2,
            this.Column3,
            this.descarga});
            this.grilla_descargas.Location = new System.Drawing.Point(7, 7);
            this.grilla_descargas.Name = "grilla_descargas";
            this.grilla_descargas.Size = new System.Drawing.Size(443, 495);
            this.grilla_descargas.TabIndex = 0;
            // 
            // asd
            // 
            this.asd.HeaderText = "Artista";
            this.asd.Name = "asd";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Titulo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Duración";
            this.Column3.Name = "Column3";
            // 
            // descarga
            // 
            this.descarga.HeaderText = "Descarga";
            this.descarga.Name = "descarga";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRutaDescarga);
            this.tabPage1.Controls.Add(this.btnSeleccionarRuta);
            this.tabPage1.Controls.Add(this.btn_nuevaBusqueda);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.txt_buscarCancion);
            this.tabPage1.Controls.Add(this.grilla);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRutaDescarga
            // 
            this.txtRutaDescarga.Enabled = false;
            this.txtRutaDescarga.Location = new System.Drawing.Point(575, 21);
            this.txtRutaDescarga.Name = "txtRutaDescarga";
            this.txtRutaDescarga.Size = new System.Drawing.Size(173, 20);
            this.txtRutaDescarga.TabIndex = 26;
            // 
            // btnSeleccionarRuta
            // 
            this.btnSeleccionarRuta.AutoSize = true;
            this.btnSeleccionarRuta.Location = new System.Drawing.Point(572, 5);
            this.btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            this.btnSeleccionarRuta.Size = new System.Drawing.Size(92, 13);
            this.btnSeleccionarRuta.TabIndex = 25;
            this.btnSeleccionarRuta.TabStop = true;
            this.btnSeleccionarRuta.Text = "Ruta de descarga";
            this.btnSeleccionarRuta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSeleccionarRuta_LinkClicked);
            // 
            // btn_nuevaBusqueda
            // 
            this.btn_nuevaBusqueda.Location = new System.Drawing.Point(311, 21);
            this.btn_nuevaBusqueda.Name = "btn_nuevaBusqueda";
            this.btn_nuevaBusqueda.Size = new System.Drawing.Size(105, 23);
            this.btn_nuevaBusqueda.TabIndex = 19;
            this.btn_nuevaBusqueda.Text = "Nueva Busqueda";
            this.btn_nuevaBusqueda.UseVisualStyleBackColor = true;
            this.btn_nuevaBusqueda.Click += new System.EventHandler(this.btn_nuevaBusqueda_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(311, 21);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar Canción";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscarCancion
            // 
            this.txt_buscarCancion.Location = new System.Drawing.Point(6, 21);
            this.txt_buscarCancion.Name = "txt_buscarCancion";
            this.txt_buscarCancion.Size = new System.Drawing.Size(299, 20);
            this.txt_buscarCancion.TabIndex = 12;
            this.txt_buscarCancion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscarCancion_KeyPress);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.lesma,
            this.artista,
            this.titulo,
            this.duracion});
            this.grilla.Location = new System.Drawing.Point(6, 57);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(742, 441);
            this.grilla.TabIndex = 16;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            // 
            // identificador
            // 
            this.identificador.HeaderText = "Identificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Visible = false;
            // 
            // lesma
            // 
            this.lesma.HeaderText = "Lesma";
            this.lesma.Name = "lesma";
            this.lesma.ReadOnly = true;
            this.lesma.Visible = false;
            this.lesma.Width = 300;
            // 
            // artista
            // 
            this.artista.HeaderText = "Artista";
            this.artista.Name = "artista";
            this.artista.ReadOnly = true;
            this.artista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artista.Width = 180;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 220;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "MetaDatos";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            this.duracion.Width = 200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 534);
            this.tabControl1.TabIndex = 20;
            // 
            // frmMusicDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(757, 538);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMusicDownloader";
            this.Text = "Music Downloader";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_descargas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grilla_descargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn asd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descarga;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_nuevaBusqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscarCancion;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtRutaDescarga;
        private System.Windows.Forms.LinkLabel btnSeleccionarRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesma;
        private System.Windows.Forms.DataGridViewTextBoxColumn artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

