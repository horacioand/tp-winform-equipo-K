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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.ShowDialog();
            cargar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificar = new frmAgregar(seleccionado);    
            modificar.ShowDialog();
            cargar();
        }

        public void cargar()
        {
            ArticuloNegocio conexionArticulo = new ArticuloNegocio();
            List<Articulo> listaArticulos = conexionArticulo.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns[0].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro?", "Eliminacion Física", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if(respuesta == DialogResult.Yes)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminarArticulo(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = dgvArticulos.CurrentRow.DataBoundItem as Articulo;
            frmDetalles detalles = new frmDetalles(seleccionado);
            detalles.ShowDialog();

        }
    }
}
