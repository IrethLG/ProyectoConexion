using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoMercadoLibre
{
    public  class Datos
    {

        private static string cadenaConexion  = "Server=localhost\\SQLEXPRESS;Database = i18050518_ArisbethLeijaGarza; Trusted_Connection = True;";
            private static SqlConnection conexion = new SqlConnection(cadenaConexion);



        public static int EjecutarConsulta(string consulta)
        {
            int registroAfectados = 0;
            SqlCommand comando = new SqlCommand(consulta,conexion);
            conexion.Open();
            registroAfectados = comando.ExecuteNonQuery();
            conexion.Close();
            return registroAfectados;
        }


        public static void AgregarDataTable(DataSet ds, string consulta, string nombreTabla,DataGridView dataGridView1)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, cadenaConexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["i18050518_ArisbethLeijaGarza"];
            
            }
            catch
            {
                MessageBox.Show("Error a introducido un registro que hace referencia en otra tabla");
            }

        }
    }
}