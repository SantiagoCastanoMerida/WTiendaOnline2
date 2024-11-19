using System;
using System.Windows.Forms;
using WTiendaOnline.Utils;


namespace WTiendaOnline.UI
{
    public partial class RecuadroProducto : UserControl
    {
        public event Action<string> OnNavigate;
        public string Nombre
        {
            get { return lblNombres.Text; }
            set { lblNombres.Text = value; }
        }

        public string Precio
        {
            get { return lblPrecios.Text; }
            set { lblPrecios.Text = value; }
        }

        public int id { get; set; }
        public RecuadroProducto()
        {
            InitializeComponent();

            lblNombres.Text = Nombre;
            lblPrecios.Text = Convert.ToString(Precio);
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            GlobalProductoId.ModificarId(id);
            OnNavigate?.Invoke("ProductoSelecionado");
        }
    }
}
