using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace Visual
{
    public partial class frmDetalles : Form
    {
        private Articulo articulo = null;
        public frmDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = articulo.CodigoArticulo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtCategoria.Text = articulo.Categoria.Descripcion;
            txtMarca.Text = articulo.Marca.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            if (articulo.Imagen.Count > 0) 
            Funciones.cargarImagen(pboArticulo, articulo.Imagen[0].Ruta);
        }
        
    }
}
