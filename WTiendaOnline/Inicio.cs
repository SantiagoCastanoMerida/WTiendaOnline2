using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WTiendaOnline.UI;


namespace WTiendaOnline
{
    public partial class Inicio : Form
    {
        private readonly UI.Login _login;
        private readonly UI.Registro _registro;
        private readonly UI.HeaderLogin _headerLogin;
        private readonly UI.HeaderTienda _headerTienda;
        private readonly UI.Productos _productos;
        private readonly UI.ProductoSelecionado _productoSelecionado;
        private readonly UI.RecuadroProducto _recuadroProducto;
        private readonly UI.CarritoDeCompras _carritoDeCompras;
        private readonly UI.Contactanos _contactanos;
        private readonly UI.AgregarProducto _agregarProdcuto;
        private readonly UI.ModificarUsuario _modificarUSuario;
        private readonly UI.ModificarProducto _modificarProducto;
        private readonly UI.ProductoBajoStock _productoBajoStock;

        public Inicio()
        {
            InitializeComponent();

            //CargarComponentes
            _login = new UI.Login();
            _registro = new UI.Registro();
            _headerLogin = new UI.HeaderLogin();
            _headerTienda = new UI.HeaderTienda();
            _productos = new UI.Productos();
            _productoSelecionado = new UI.ProductoSelecionado();
            _recuadroProducto = new UI.RecuadroProducto();
            _carritoDeCompras = new UI.CarritoDeCompras();
            _contactanos = new UI.Contactanos();
            _agregarProdcuto = new UI.AgregarProducto();
            _modificarUSuario = new UI.ModificarUsuario();
            _modificarProducto = new UI.ModificarProducto();
            _productoBajoStock = new UI.ProductoBajoStock();

            //Agregar evento Navigate
            _login.OnNavigate += Navegar;
            _registro.OnNavigate += Navegar;
            _headerTienda.OnNavigate += Navegar;
            _productos.OnNavigate += Navegar;
            _recuadroProducto.OnNavigate += Navegar;
            _modificarUSuario.OnNavigate += Navegar;
            _productoSelecionado.OnNavigate += Navegar;

            

            //Cargar panel principal
            Controls.Add(_headerLogin);
            Controls.Add(_login);

        }

        //Ver panel a cargar
        private void Navegar(string panelRuta)
        {
            UserControl panel;

            switch (panelRuta)
            {
                case "Registro":
                    panel = _registro;
                    break;
                case "Login":
                    panel = _login;
                    break;
                case "Productos":
                    panel = _productos;
                    RecargarProductos(panel);
                    break;
                case "ProductoSelecionado":
                    panel = _productoSelecionado;
                    break;
                case "CarritoDeCompras":
                    panel = _carritoDeCompras;
                    break;
                case "Contactanos":
                    panel = _contactanos;
                    break;
                case "RecuadroPanel":
                    panel = _recuadroProducto;
                    break;
                case "Agregar":
                    panel = _agregarProdcuto;
                    break;
                case "ModificarUsuario":
                    panel = _modificarUSuario; 
                    break;
                case "ModificarProducto":
                    panel = _modificarProducto;
                    RecargarProductos(panel);
                    break;
                case "ProductoSelecioando":
                    panel = _productoSelecionado;
                    break;
                case "AgregarProducto":
                    panel = _agregarProdcuto;
                    break;
                case "StockBajo":
                    panel = _productoBajoStock;
                    RecargarProductos(panel);
                    break;
                default:
                    panel = _login;
                    break;
            }
            Cargar(panel);

        }
        //Actualizar lsita productos
        private void RecargarProductos(UserControl panel)
        {
            if (panel == _productos)
            {
                _productos.LimpiarVista();
                _productos.CargarProductos();
            }
            if (panel == _modificarProducto)
            {
                _modificarProducto.CargarListaProductos();
            }
            if(panel == _productoBajoStock)
            {
                _productoBajoStock.LimpiarVista();
                _productoBajoStock.CargarProductos();
            }
        }

        //limpiar y cargar paneles
        private void Cargar(UserControl panel)
        {
            if (panel == _productoSelecionado) 
            {
                Controls.Add(panel);
                panel.BringToFront();
                return;
            }
            Controls.Clear();
            
            if (panel == _login || panel == _registro)
            {
                Controls.Add(_headerLogin);
            }
            else
            {
                Controls.Add(_headerTienda);
            }
            Controls.Add(panel);
        }
    }
}
