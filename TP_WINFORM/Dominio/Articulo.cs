using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
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
        [DisplayName("Código")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public List<Imagen> Imagen { get; set; }
        public decimal Precio { get; set; }
        
    }
}
