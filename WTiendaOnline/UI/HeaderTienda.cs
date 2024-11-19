using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTiendaOnline.UI
{
    public partial class HeaderTienda : UserControl
    {
        public event Action<string> OnNavigate;
        public HeaderTienda()
        {
            InitializeComponent();

            //Inicializar campos
            btnHome.Text = "Inicio";
            btnContacto.Text = "Contacto";
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("CarritoDeCompras");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("Productos");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("ModificarUsuario");
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("Contactanos");
        }
    }
}
