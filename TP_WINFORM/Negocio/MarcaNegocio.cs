using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Marca> listaMarca = new List<Marca>();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();
                while (datos.Reader.Read())
                {
                    Marca auxiliar = new Marca();
                    if (!(datos.Reader["Id"] is DBNull))
                        auxiliar.Id = (int)datos.Reader["Id"];
                    if (!(datos.Reader["Descripcion"] is DBNull))
                        auxiliar.Descripcion = (string)datos.Reader["Descripcion"];
                    listaMarca.Add(auxiliar);
                }
                return listaMarca;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void agregar(string nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES ('" + nuevo + "')");
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
