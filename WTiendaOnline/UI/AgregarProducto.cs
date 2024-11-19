using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTiendaOnline.Services;

namespace WTiendaOnline.UI
{
    public partial class AgregarProducto : UserControl
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt64(txtPrecio.Text) <= 0)
                {
                    MessageBox.Show("Debe ingresar un precio mayor a 0$");
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe ingresar todos los datos");
                    return;
                }
                CrearProductoBd crearProducto = new CrearProductoBd();
                if (crearProducto.CrearProducto(txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text)))
                {
                    MessageBox.Show("Producto Creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar todos los datos");
            }
        }
    }
}
