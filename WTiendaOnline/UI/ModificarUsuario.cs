using System;
using System.Windows.Forms;
using WTiendaOnline.Models;
using WTiendaOnline.Services;
using WTiendaOnline.Utils;

namespace WTiendaOnline.UI
{
    public partial class ModificarUsuario : UserControl
    {
        
        public event Action<string> OnNavigate;
        public ModificarUsuario()
        {
            InitializeComponent();

            txtNombre.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            btnModificar.Enabled = false;
        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtTelefono.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Enabled == false)
            {
                txtNombre.Enabled = true;
                txtEmail.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                btnModificar.Enabled = true;
                return;
            }
            txtNombre.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("AgregarProducto");
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ObtenerUsuarioBd usuario = new ObtenerUsuarioBd();
            string email = GlobalClienteEmail.MostrarEmail();
            cliente = usuario.ObtenerDatos(email);
            txtNombre.Text = cliente.name;
            txtTelefono.Text = cliente.telefono;
            txtDireccion.Text = cliente.direccion;
            txtEmail.Text = cliente.email;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Ningun dato puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string emailActual = GlobalClienteEmail.MostrarEmail();
            ModificarUsuarioBd usuario = new ModificarUsuarioBd();
            if (usuario.ModificarUsuario(txtNombre.Text, txtEmail.Text, txtDireccion.Text, txtTelefono.Text, emailActual))
            {
                MessageBox.Show("Usuario actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("ModificarProducto");
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStock.Text)) 
            {
                GlobalStock.ModificarStock(Convert.ToInt32(txtStock.Text));
                OnNavigate?.Invoke("StockBajo");
                return;
            }
            MessageBox.Show("Primero debe ingresar un stock minimo");
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
