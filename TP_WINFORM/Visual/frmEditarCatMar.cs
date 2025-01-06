using Dominio;
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

namespace Visual
{
    public partial class frmEditarCatMar : Form
    {
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        public frmEditarCatMar()
        {
            InitializeComponent();
        }

        private void frmEditarCatMar_Load(object sender, EventArgs e)
        {
            cboEdicionCatMar.Items.Add("Categoria");
            cboEdicionCatMar.Items.Add("Marca");
            
        }

        private void cboEdicionCatMar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEdicionCatMar.SelectedIndex == -1)
            {
                return;
            }
            if (cboEdicionCatMar.SelectedItem.ToString() == "Categoria")
            {
                dgvEdicionCatMar.DataSource = categoriaNegocio.listar();
            }
            else
            {
                dgvEdicionCatMar.DataSource = marcaNegocio.listar();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEdicionCatMar.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados en la tabla, seleccione un elemento");
                return;
            }
            txtDescripcion.Enabled = true;
            btnAceptar.Enabled = true;
            dgvEdicionCatMar.Enabled = false;
            btnCancelarEdicion.Visible = true;
            btnEliminar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion");
                return;
            }
            else
            {
                if (dgvEdicionCatMar.CurrentRow.DataBoundItem is Categoria)
                {
                    Categoria seleccionada = (Categoria)dgvEdicionCatMar.CurrentRow.DataBoundItem;
                    seleccionada.Descripcion = txtDescripcion.Text;
                    categoriaNegocio.editar(seleccionada);
                    MessageBox.Show("Categoria editada con exito");
                    dgvEdicionCatMar.DataSource = categoriaNegocio.listar();
                    txtDescripcion.Enabled = false;
                    txtDescripcion.Text = "";
                    btnAceptar.Enabled = false;
                    dgvEdicionCatMar.Enabled = true;
                    btnCancelarEdicion.Visible = false; 
                }
                else
                {
                    Marca seleccionada = (Marca)dgvEdicionCatMar.CurrentRow.DataBoundItem;
                    seleccionada.Descripcion = txtDescripcion.Text;
                    marcaNegocio.editar(seleccionada);
                    MessageBox.Show("Marca editada con exito");
                    dgvEdicionCatMar.DataSource = marcaNegocio.listar();
                    txtDescripcion.Enabled = false;
                    txtDescripcion.Text = "";
                    btnAceptar.Enabled = false;
                    dgvEdicionCatMar.Enabled = true;
                    btnCancelarEdicion.Visible = false;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEdicionCatMar.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados en la tabla, seleccione un elemento");
                return;
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Desea borrar el registro?", "Registro eliminado", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    if (dgvEdicionCatMar.CurrentRow.DataBoundItem is Categoria)
                    {
                        Categoria seleccionada = (Categoria)dgvEdicionCatMar.CurrentRow.DataBoundItem;
                        categoriaNegocio.eliminar(seleccionada);
                        MessageBox.Show("Categoria eliminada con exito");
                        dgvEdicionCatMar.DataSource = categoriaNegocio.listar();
                    }
                    else
                    {
                        Marca seleccionada = (Marca)dgvEdicionCatMar.CurrentRow.DataBoundItem;
                        marcaNegocio.eliminar(seleccionada);
                        MessageBox.Show("Marca eliminada con exito");
                        dgvEdicionCatMar.DataSource = marcaNegocio.listar();
                    }
                }
            }
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = false;
            btnAceptar.Enabled = false;
            dgvEdicionCatMar.Enabled = true;
            btnCancelarEdicion.Visible = false;
            btnEliminar.Enabled = true;
        }
    }
}
