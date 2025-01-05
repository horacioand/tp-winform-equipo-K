using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listarImg(int id)
        {
            List<Imagen> listaImagenes = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id, ImagenUrl FROM IMAGENES WHERE IdArticulo = " + id);
                datos.ejecutarLectura();
                while(datos.Reader.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Reader["Id"];
                    aux.Ruta = (string)datos.Reader["ImagenUrl"];
                    listaImagenes.Add(aux);
                }
                return listaImagenes;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void EliminarImagen(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM IMAGENES WHERE id = @id");
                datos.setearParametro("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AgregarImg(int idArt, string img)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArt, @Ruta)");
                datos.setearParametro("@IdArt", idArt);
                datos.setearParametro("@Ruta", img);

                datos.ejecutarAccion();
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
