using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTiendaOnline.Utils
{
    public class GlobalClienteEmail
    {
        public static string Email;

        public static void ModificarEmail(string email)
        {
            Email = email;
        }

        public static string MostrarEmail()
        {
            return Email;
        }
    }
}
