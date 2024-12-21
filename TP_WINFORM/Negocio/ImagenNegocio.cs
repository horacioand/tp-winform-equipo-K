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
        public List<Imagen> listar()
        {
            return new List<Imagen>();
            //terminar 
        }
        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @Url)");
                datos.setearParametro("@idArticulo", articulo.Id);
                datos.setearParametro("@Url", articulo.Imagen[0].Ruta);
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
