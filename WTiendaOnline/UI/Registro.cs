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
using WTiendaOnline.Utils;

namespace WTiendaOnline.UI
{
    public partial class Registro : UserControl
    {
        public event Action<string> OnNavigate;
        public Registro()
        {
            InitializeComponent();

            //Inicializar componentes
            btnRegistrarse.Text = "Registrarse";
            lblLogin.Text = "¿No tienes una cuenta?";
            lblTitulo.Text = "Registrarse";
            lblNombre.Text = "Nombre";
            lblDireccion.Text = "Direccion";
            lblEmail.Text = "Email";
            lblTelefono.Text = "Telefono";
            hlkLogin.Text = "Iniciar sesión";

        }
        //Realizar Registo en la base de datos
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe Ingresar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CrearUsuariosBd Usuario = new CrearUsuariosBd();
            if (Usuario.CrearUsuario(txtNombre.Text,txtEmail.Text,txtDireccion.Text,txtTelefono.Text)) 
            {
                MessageBox.Show("Usuario Creado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalClienteEmail.ModificarEmail(txtEmail.Text);
                OnNavigate?.Invoke("Login");
                return;
            }
            MessageBox.Show("Error Al crear el usuario", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Navegar al login
        private void hlkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnNavigate?.Invoke("Login");
        }

        private void textTelefonoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtTelefono.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
