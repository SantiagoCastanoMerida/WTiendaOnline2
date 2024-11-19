using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTiendaOnline.UI;

namespace WTiendaOnline.Utils
{
    public class GlobalProductoId
    {
        public static int Id;
        
        public static void ModificarId (int id)
        {
            Id = id;
        }

        public static int MostrarId()
        {
            return Id;
        }
    }
}
