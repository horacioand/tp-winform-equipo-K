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
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, C.Descripcion AS Categoria, M.Descripcion AS Marca, Precio, C.Id AS idCategoria, M.Id AS idMarca FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C on A.IdCategoria = C.Id");
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
                    auxiliar.Categoria = new Categoria();
                    if (!(datos.Reader["Categoria"] is DBNull))
                        auxiliar.Categoria.Descripcion = (string)datos.Reader["Categoria"];
                    else
                        auxiliar.Categoria.Descripcion = "Sin Asignar";

                    if (!(datos.Reader["idCategoria"] is DBNull))
                        auxiliar.Categoria.Id = (int)datos.Reader["idCategoria"];

                        auxiliar.Marca = new Marca();
                    if (!(datos.Reader["Marca"] is DBNull))
                        auxiliar.Marca.Descripcion = (string)datos.Reader["Marca"];
                    else
                        auxiliar.Marca.Descripcion = "Sin Asignar";


                    if (!(datos.Reader["idMarca"] is DBNull))
                        auxiliar.Marca.Id = (int)datos.Reader["idMarca"];

                    if (!(datos.Reader["Precio"] is DBNull))
                        auxiliar.Precio = (decimal)datos.Reader["Precio"];

                    ImagenNegocio imagenNegocio = new ImagenNegocio();  
                    List<Imagen> listaImagenes = imagenNegocio.listarImg(auxiliar.Id);
                    auxiliar.Imagen = listaImagenes;

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
        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @cod, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria =@idCat, Precio =@Precio WHERE Id = @Id");
                datos.setearParametro("@cod",articulo.CodigoArticulo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion",articulo.Descripcion);
                datos.setearParametro("@idMarca",articulo.Marca.Id);
                datos.setearParametro("@idCat",articulo.Categoria.Id);
                datos.setearParametro("@Precio",articulo.Precio);
                datos.setearParametro("@Id", articulo.Id);
                datos.ejecutarAccion();
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
        public void eliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE ID = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Articulo> filtrarArticulo(string campo, string criterio, string filtro)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Id AS idMarca, M.Descripcion AS Marca, c.Id AS idCategoria, C.Descripcion AS Categoria, Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE IdMarca = M.Id AND IdCategoria = C.Id AND ";
                if (campo == "Precio")
                {
                    if (string.IsNullOrEmpty(filtro))
                    {
                        filtro = "0";
                    }
                    switch (criterio)
                    {
                        case ("Mayor a"):
                            consulta += "Precio > " + filtro;
                            break;
                        case ("Menor a"):
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case ("Comienza con.."):
                            consulta += "Codigo like '" + filtro + "%'";
                            break;
                        case ("Termina con.."):
                            consulta += "Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;
                    }
                }else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case ("Comienza con.."):
                            consulta += "Nombre like '" + filtro + "%'";
                            break;
                        case ("Termina con.."):
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }else if (campo == "Descripcion")
                {
                    switch (criterio)
                    {
                        case ("Comienza con.."):
                            consulta += "A.Descripcion like '" + filtro + "%'";
                            break;
                        case ("Termina con.."):
                            consulta += "A.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case ("Comienza con.."):
                            consulta += "M.Descripcion like '" + filtro + "%'";
                            break;
                        case ("Termina con.."):
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }else
                {
                    switch (criterio)
                    {
                        case ("Comienza con.."):
                            consulta += "C.Descripcion like '" + filtro + "%'";
                            break;
                        case ("Termina con.."):
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Reader.Read())
                {
                    Articulo auxiliar = new Articulo();
                    ImagenNegocio imagenNegocio = new ImagenNegocio();
                    auxiliar.Id = (int)datos.Reader["Id"];
                    if (!(datos.Reader["Codigo"] is DBNull))
                        auxiliar.CodigoArticulo = (string)datos.Reader["Codigo"];
                    if (!(datos.Reader["Nombre"] is DBNull))
                        auxiliar.Nombre = (string)datos.Reader["Nombre"];
                    if (!(datos.Reader["Descripcion"] is DBNull))
                        auxiliar.Descripcion = (string)datos.Reader["Descripcion"];
                    
                    auxiliar.Imagen = new List<Imagen>();
                    auxiliar.Imagen = imagenNegocio.listarImg(auxiliar.Id);
                    
                    if (!(datos.Reader["Precio"] is DBNull))
                        auxiliar.Precio = (decimal)datos.Reader["Precio"];
                    auxiliar.Marca = new Marca();
                    if (!(datos.Reader["idMarca"] is DBNull))
                        auxiliar.Marca.Id = (int)datos.Reader["idMarca"];
                    if (!(datos.Reader["Marca"] is DBNull))
                        auxiliar.Marca.Descripcion = (string)datos.Reader["Marca"];
                    auxiliar.Categoria = new Categoria();
                    if (!(datos.Reader["idCategoria"] is DBNull))
                        auxiliar.Categoria.Id = (int)datos.Reader["idCategoria"];
                    if (!(datos.Reader["Categoria"] is DBNull))
                        auxiliar.Categoria.Descripcion = (string)datos.Reader["Categoria"];
                    listaArticulos.Add(auxiliar);
                }
                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
