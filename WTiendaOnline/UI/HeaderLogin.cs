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
    public partial class HeaderLogin : UserControl
    {
        public HeaderLogin()
        {
            InitializeComponent();

            //Inicializar compontentes
            lblEslogan.Text = "¡Descubre lo que deseas a un clic de distancia!";
        }
    }
}
