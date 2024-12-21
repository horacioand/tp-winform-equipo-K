using Negocio;
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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo nuevoArticulo = new Articulo();
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                ImagenNegocio imagenNegocio = new ImagenNegocio();

                nuevoArticulo.CodigoArticulo = txtCodigo.Text;
                nuevoArticulo.Nombre = txtNombre.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                nuevoArticulo.Imagen = new List<Imagen>();
                nuevoArticulo.Imagen.Add(new Imagen());
                nuevoArticulo.Id = int.Parse(txtId.Text);
                nuevoArticulo.Imagen[0].Ruta = txtImagen.Text;
                nuevoArticulo.Marca = (Marca)cboMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articuloNegocio.agregar(nuevoArticulo);
                imagenNegocio.agregar(nuevoArticulo);
                MessageBox.Show("Agregado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void cargarImagen(string imagen)
        {

            try
            {
                pboArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pboArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9cSGzVkaZvJD5722MU5A-JJt_T5JMZzotcw&s");
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
    }
}
