﻿using Negocio;
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
        public frmAgregar()
        {
            InitializeComponent();
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
                imagenNegocio.AgregarImg(articulo.Id, txtImagen.Text);

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

    }
}
