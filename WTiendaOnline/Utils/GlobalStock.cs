using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTiendaOnline.Utils
{
    public class GlobalStock
    {
        public static int Stock;

        public static void ModificarStock(int stock)
        {
            Stock = stock;
        }

        public static int MostrarStock()
        {
            return Stock;
        }
    }
}
