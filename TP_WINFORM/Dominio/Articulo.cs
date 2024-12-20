using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /*
      Código de artículo.
    Nombre.
    Descripción.
    Marca (seleccionable de una lista desplegable).
    Categoría (seleccionable de una lista desplegable.
    Imagen.
    Precio.
    */
    public class Articulo
    {
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagen> Imagen { get; set; }
        public float Precio { get; set; }
    }
}
