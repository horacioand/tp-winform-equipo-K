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
        public List<Articulo> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void cargar()
        {
            ArticuloNegocio conexionArticulo = new ArticuloNegocio();
            listaArticulos = conexionArticulo.listar();
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


        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.ShowDialog();
            cargar();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns[0].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow == null)
            {
                return;
            }
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            lblSeleccionado.Text = seleccionado.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)//filtro avanzado
        {
            frmFiltroAvanzado frmFiltroAvanzado = new frmFiltroAvanzado();
            frmFiltroAvanzado.ShowDialog();
            cargar();
        }

        private void tsmAgregarCatMar_Click(object sender, EventArgs e)
        {
            frmAgregarCatMar frmAgregarCatMar = new frmAgregarCatMar();
            frmAgregarCatMar.ShowDialog();
            cargar();
        }

        private void tsmModificarCategoria_Click(object sender, EventArgs e)
        {
            frmEditarCatMar frmEditarCatMar = new frmEditarCatMar();
            frmEditarCatMar.ShowDialog();
            cargar();
        }
    }
}
