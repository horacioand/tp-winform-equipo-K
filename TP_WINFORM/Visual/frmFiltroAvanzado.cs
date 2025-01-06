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
    public partial class frmFiltroAvanzado : Form
    {
        public frmFiltroAvanzado()
        {
            InitializeComponent();
        }
        private void frmFiltroAvanzado_Load(object sender, EventArgs e)
        {
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (Funciones.validarFiltro(cboCampo,cboCriterio,txtFiltro))
                {
                    return;
                }
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvFiltroAvanzado.DataSource = articuloNegocio.filtrarArticulo(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con..");
                cboCriterio.Items.Add("Termina con..");
                cboCriterio.Items.Add("Contiene..");
            }
        }
    }
}
