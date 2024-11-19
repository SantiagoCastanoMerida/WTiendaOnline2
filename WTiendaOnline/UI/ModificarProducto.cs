using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTiendaOnline.Models;
using WTiendaOnline.Services;
using WTiendaOnline.Utils;

namespace WTiendaOnline.UI
{
    
    public partial class ModificarProducto : UserControl
    {
        private List<Producto> productos = new List<Producto>();
        private Producto producto = new Producto();
        public ModificarProducto()
        {
            InitializeComponent();

            cmbProductos.SelectedItem = 0;
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDown;


        }

        public void CargarListaProductos()
        {
            cmbProductos.Items.Clear();

            ObtenerProductosBd obtener = new ObtenerProductosBd();
            productos = obtener.Productos();
            foreach (var producto in productos)
            {
                cmbProductos.Items.Add(producto.name);
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerProductosBd obtener = new ObtenerProductosBd();
            int id = cmbProductos.SelectedIndex+1;
            GlobalProductoId.ModificarId(id);
            producto = obtener.obtenerPorId(id);
            txtNombre.Text = producto.name;
            txtCantidad.Text = Convert.ToString(producto.cantidad);
            txtDescripcion.Text = producto.descripcion;
            txtPrecio.Text = Convert.ToString(producto.precio);
   
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
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
                ModificarProductoBd modificarProducto = new ModificarProductoBd();
                int id = GlobalProductoId.MostrarId();
                if (modificarProducto.ModificarProducto(id, txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text)))
                {
                    MessageBox.Show("Producto Modificado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar todos los datos");
            } 
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
