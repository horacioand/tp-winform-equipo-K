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
        private Articulo articulo = null;
        private int indiceImagenActual = 0;
        public frmAgregar()
        {
            InitializeComponent();
            btnSiguiente.Visible = false;
            btnAnterior.Visible = false;
            lblEliminarImgX.Visible = false;
            lblEliminarImgX.Enabled = false;
            lblEliminarImg.Visible = false;
            txtImagen.Enabled = false;
            btnAgregarImg.Enabled = false;
            txtImagen.Text = "Primero ingrese el artículo";
        }
        public frmAgregar(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            Text = "Modificar Articulo";
            lblAgregarArticulo.Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulo != null) 
                {
                    if(articulo.Imagen.Count > 0)
                    {
                        txtImagen.Text = articulo.Imagen[0].Ruta;
                        Funciones.cargarImagen(pboArticulo,txtImagen.Text);
                    }
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Creo una lista de imagenes para luego mandarla a la db
        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            Imagen temporal = new Imagen();
            temporal.IdArticulo = articulo.Id;
            temporal.Ruta = txtImagen.Text;
            articulo.Imagen.Add(temporal);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {
                if (Funciones.validarIngreso(txtCodigo,txtNombre,txtPrecio))
                {
                    return;
                }
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                foreach (var item in articulo.Imagen)
                {
                    imagenNegocio.AgregarImg(articulo.Id, txtImagen.Text);
                }

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }

                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtImagen_Leave(object sender, EventArgs e)
        {
            Funciones.cargarImagen(pboArticulo, txtImagen.Text);
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
        private void MostrarImagen(int indice)
        {

            Funciones.cargarImagen(pboArticulo,articulo.Imagen[indice].Ruta);
        }

        private void lblEliminarImgX_Click(object sender, EventArgs e)
        {
            // Verificar si el índice es válido y la lista no está vacía
            if (articulo.Imagen.Count > 0 && indiceImagenActual >= 0 && indiceImagenActual < articulo.Imagen.Count)
            {
                // Eliminar la imagen de la lista en el índice actual
                
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                imagenNegocio.EliminarImagen(articulo.Imagen[indiceImagenActual].Id);
                articulo.Imagen.RemoveAt(indiceImagenActual);
                // Verificar si después de eliminar aún quedan imágenes en la lista
                if (articulo.Imagen.Count > 0)
                {
                    // Asegurarse de que el índice no quede fuera de rango
                    if (indiceImagenActual >= articulo.Imagen.Count)
                    {
                        indiceImagenActual = articulo.Imagen.Count - 1;
                    }

                    // Mostrar la siguiente imagen o la anterior después de eliminar
                    MostrarImagen(indiceImagenActual);
                }
                else
                {
                    // Si no quedan imágenes, borrar el PictureBox (o mostrar un mensaje de no hay imágenes)
                    pboArticulo.Image = null;
                    MessageBox.Show("No quedan imágenes para mostrar.");
                }
            }
            else
            {
                // Si el índice no es válido o la lista está vacía, mostrar un mensaje de error
                MessageBox.Show("No se puede eliminar la imagen. El índice es inválido o no hay imágenes.");
            }
        }

        
    }
}
