using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    public class Resultados
    {
        public void Agregar(string busqueda,int cantidadResultados,string fecha) 
        {
            SqlConnection conexion = new SqlConnection("Data Source=ASUS-H95TKI5\\SQLEXPRESS;Initial Catalog=MusicaBD;Persist Security Info=True;User ID=sa;Password=esea");
            SqlCommand cmd = new SqlCommand("Insert Into Busquedas (busqueda,cantidadResultados,fecha) Values (@busqueda,@cantidadResultados,@fecha)",conexion);

            cmd.Parameters.AddWithValue("@busqueda", busqueda);
            cmd.Parameters.AddWithValue("@cantidadResultados", cantidadResultados);
            cmd.Parameters.AddWithValue("@fecha", fecha);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable BuscarTodos()
        {
            SqlConnection conexion = new SqlConnection("Data Source=ASUS-H95TKI5\\SQLEXPRESS;Initial Catalog=MusicaBD;Persist Security Info=True;User ID=sa;Password=esea");
            SqlCommand cmd = new SqlCommand("Select busqueda,cantidadResultados From Busquedas Order By Id DESC", conexion);

            conexion.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            conexion.Close();

            return dt;
        }

    }
}
