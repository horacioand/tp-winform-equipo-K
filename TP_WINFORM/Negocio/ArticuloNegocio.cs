using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            AccesoDatos datos = new AccesoDatos();  
            List<Articulo> listaArticulos = new List<Articulo>();
            try
            {
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, C.Descripcion AS Categoria, M.Descripcion AS Marca, Precio FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE IdMarca = M.Id AND IdCategoria = C.Id");
                datos.ejecutarLectura();
                while (datos.Reader.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Id = (int)datos.Reader["Id"];
                    if (!(datos.Reader["Codigo"]is DBNull))
                        auxiliar.CodigoArticulo = (string)datos.Reader["Codigo"];
                    if (!(datos.Reader["Nombre"] is DBNull))
                        auxiliar.Nombre = (string)datos.Reader["Nombre"];
                    if (!(datos.Reader["Descripcion"] is DBNull))
                        auxiliar.Descripcion = (string)datos.Reader["Descripcion"];
                    if (!(datos.Reader["Categoria"] is DBNull))
                    {
                        auxiliar.Categoria = new Categoria();
                        auxiliar.Categoria.Descripcion = (string)datos.Reader["Categoria"];
                    }
                    if (!(datos.Reader["Marca"] is DBNull))
                    {
                        auxiliar.Marca = new Marca();
                        auxiliar.Marca.Descripcion = (string)datos.Reader["Marca"];
                    }
                    if (!(datos.Reader["Precio"] is DBNull))
                        auxiliar.Precio = (decimal)datos.Reader["Precio"];
                    listaArticulos.Add(auxiliar);
                }
                return listaArticulos;
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
        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,IdMarca,IdCategoria,Precio) VALUES ('"+articulo.CodigoArticulo+"','"+articulo.Nombre+"','"+articulo.Descripcion+"',@idMarca,@idCategoria,"+articulo.Precio+")");
                datos.setearParametro("@idMarca",articulo.Marca.Id);
                datos.setearParametro("@idCategoria",articulo.Categoria.Id);
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
