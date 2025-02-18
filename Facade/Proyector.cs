using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Proyector
    {
        public string On()
        {
            return "Proyector encendido";
        }
        public string Off() {
            return "Proyector apagado";
        }
        public string AdjustResolution()
        {
            return "Resolución ajustada";
        }

    }
}
