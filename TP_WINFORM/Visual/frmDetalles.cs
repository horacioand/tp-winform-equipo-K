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
using Negocio;
namespace Visual
{
    public partial class frmDetalles : Form
    {
        private int indiceImagenActual = 0;
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
        private void MostrarImagen(int indice)
        {

            Funciones.cargarImagen(pboArticulo, articulo.Imagen[indice].Ruta);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual > 0)
            {
                indiceImagenActual--;
                MostrarImagen(indiceImagenActual);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual < articulo.Imagen.Count - 1)
            {
                indiceImagenActual++;
                MostrarImagen(indiceImagenActual);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
