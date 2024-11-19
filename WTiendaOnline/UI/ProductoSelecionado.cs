using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTiendaOnline.Utils;

namespace WTiendaOnline.UI
{
    public partial class ProductoSelecionado : UserControl
    {
        public event Action<string> OnNavigate;

        public ProductoSelecionado()
        {
            InitializeComponent();
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("Productos");

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(GlobalProductoId.MostrarId()));
        }
    }
}
