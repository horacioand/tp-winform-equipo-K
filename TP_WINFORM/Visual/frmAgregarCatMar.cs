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
    public partial class frmAgregarCatMar : Form
    {
        public frmAgregarCatMar()
        {
            InitializeComponent();
        }
        private void frmAgregarCatMar_Load(object sender, EventArgs e)
        {
            cboCatMar.Items.Add("Categoria");
            cboCatMar.Items.Add("Marca");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboCatMar.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría o marca.");
                return;
            }
            if (cboCatMar.SelectedItem.ToString() == "Categoria")
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese la Categoria");
                    return;
                }
                else
                {
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    categoriaNegocio.agregar(txtDescripcion.Text);
                    MessageBox.Show("Categoria agregada correctamente");
                }
            }
            else if (cboCatMar.SelectedItem.ToString() == "Marca")
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese la Marca");
                    return;
                }
                else
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    marcaNegocio.agregar(txtDescripcion.Text);
                    MessageBox.Show("Marca agregada correctamente");
                }
            }
            Close();
        }
    }
}
