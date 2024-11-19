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
    public partial class Contactanos : UserControl
    {
        public Contactanos()
        {
            InitializeComponent();

            //Inicializar componentes
            lblTitulo.Text = "Contacto";
            lblDescripcion1.Text = "Nuestro objetivo es brindar a nuestros clientes una experiencia de compra en línea confiable," +
                " fácil y satisfactoria,\r\ndonde puedan encontrar productos de alta calidad que respondan a sus necesidades y" +
                " gustos. Nos esforzamos por\r\nofrecer una plataforma accesible, segura y ágil, donde cada cliente pueda explorar " +
                "nuestro catálogo, realizar su compra\r\ny recibir su pedido en el menor tiempo posible a tan solo un cilc.";
            lblDescripcion2.Text = "¡Estamos aquí para ayudarte! Si tienes preguntas sobre nuestros productos, tu pedido, o cualquier aspecto de tu\r\n " +
                "experiencia de compra, no dudes en ponerte en contacto con nosotros. Puedes escribirnos a través de nuestro\r\n " +
                "formulario de contacto, enviarnos un correo o comunicarte por teléfono. Nuestro equipo de atención al cliente\r\n " +
                "estará encantado de asistirte y resolver todas tus inquietudes.";
            lblTerminos1.Text = "Cilc&Shop opera en Colombia y es responsable de la venta de productos\r\n" +
                " disponibles en el sitio web www .clic&shop.com.\r\nAl comprar en nuestro sitio web, confirma que tienes " +
                "al menos 18 años\r\n de edad o que realiza la compra con el consentimiento de un tutor legal.";
            lblTerminos2.Text = "Estos Términos y Condiciones se regirán e interpretarán de\r\n acuerdo con las leyes de Colombia," +
                " y cualquier disputa\r\n estará sujeta a la jurisdicción de los tribunales correspondientes";
            lblDevoluciones.Text = "Los tiempos de envío y entrega pueden variar según la ubicación del\r\ncliente" +
                " y la disponibilidad del producto. Ofrecemos estimaciones de \r\nentrega, pero estas pueden estar sujetas a" +
                " retrasos imprevistos.\r\nOfrecemos una política de devoluciones válida durante 30 días desde\r\n la recepción " +
                "del producto. Los productos deben devolverse en su estado\r\n original, sin uso y en su empaque original.";
        }
    }
}
