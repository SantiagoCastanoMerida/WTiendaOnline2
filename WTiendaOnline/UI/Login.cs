using System;
using System.Windows.Forms;
using WTiendaOnline.Services;
using WTiendaOnline.Utils;

namespace WTiendaOnline.UI
{
    public partial class Login : UserControl
    {
        public event Action<string> OnNavigate;
        public Login()
        {
            InitializeComponent();

            //Inicializar componentes
            btnLogin.Text = "Iniciar Sesión";
            lblTituloLogin.Text = "Bienvenido a Clic&Shop";
            lblEmail.Text = "Email";
            lblTelefono.Text = "Telefono";
            lblRegistro.Text = "¿Ya tienes una cuenta?";
            hlkRegistro.Text = "Registrate";

        }
        //Buscar usuario en la base de datos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ObtenerUsuarioBd usuario = new ObtenerUsuarioBd();
            if (usuario.conseguirUsuarioLogin(txtEmail.Text, txtTelefono.Text))
            {
                GlobalClienteEmail.ModificarEmail(txtEmail.Text);
                OnNavigate?.Invoke("Productos");
                return;
            }
            MessageBox.Show("Usuario no encontrado o Telefono incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }

        //navegar a el Registro
        private void hlkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnNavigate?.Invoke("Registro");
        }

        private void txtContraseñaLogin_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
