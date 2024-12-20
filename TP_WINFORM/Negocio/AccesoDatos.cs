using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader reader;
        public SqlDataReader Reader { get { return reader; } }


        public AccesoDatos()
        {
            //atentos al nombre del servidor > vean si usan SQLEXPRESS01 o SQLEXPRESS
            conexion = new SqlConnection("server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=TRUE");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                reader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void cerrarConexion()
        {
            if (reader != null)
            {
                reader.Close();
            }
            conexion.Close();
        }
    }
}
