using System;
using System.Collections.Generic;
using System.Linq;
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
                    auxiliar.CodigoArticulo = (string)datos.Reader["Codigo"];
                    auxiliar.Nombre = (string)datos.Reader["Nombre"];
                    auxiliar.Descripcion = (string)datos.Reader["Descripcion"];
                    auxiliar.Categoria = new Categoria();
                    auxiliar.Categoria.Descripcion = (string)datos.Reader["Categoria"];
                    auxiliar.Marca = new Marca();
                    auxiliar.Marca.Descripcion = (string)datos.Reader["Marca"];
                    auxiliar.Precio = (decimal)datos.Reader["Precio"];
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
