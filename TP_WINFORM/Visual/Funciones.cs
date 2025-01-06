using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public static class Funciones
    {
        public static void cargarImagen(PictureBox ubicacion, string imagen)
        {
            try
            {
                ubicacion.Load(imagen);
            }
            catch (Exception)
            {
                ubicacion.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8bikI-KUuM1IWosgqDRS5jyv2U_PPYlG6Tg&s");
            }
        }


        public static bool validarIngreso(TextBox codigo, TextBox nombre, TextBox precio)
        {
            if (string.IsNullOrEmpty(codigo.Text))
            {
                MessageBox.Show("Por favor, ingrese el código del artículo");
                return true;
            }
            if (string.IsNullOrEmpty(nombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del artículo");
                return true;
            }
            if (string.IsNullOrEmpty(precio.Text))
            {
                MessageBox.Show("Por favor, ingrese el precio del artículo");
                return true;
            }
            if (!(soloNumeros(precio.Text)))
            {
                MessageBox.Show("Por favor, el campo precio debe contener solo números");
                return true;
            }
            return false;
        }
        //hacer mas genericos los metodos de validacion y unificarlos o sobrecargar
        public static bool validarFiltro(ComboBox campo, ComboBox criterio, TextBox filtro)
        {
            if (campo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un campo a filtrar");
                return true;
            }
            if (criterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un criterio a filtrar");
                return true;
            }
            if (campo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(filtro.Text))
                {
                    MessageBox.Show("Por favor, ingrese un dato para filtrar por precio");
                    return true;
                }
                if (!(soloNumeros(filtro.Text)))
                {
                    MessageBox.Show("Por favor, ingrese solo números para filtrar por precio");
                    return true;
                }
            }
            return false;
        }

        public static bool esDecimal(string texto)
        {
            decimal resultado;
            return decimal.TryParse(texto, out resultado);
        }


        public static bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
