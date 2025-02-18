using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Speakers
    {
        public string On()
        {
            return "Speaker encendido";
        }
        public string Off()
        {
            return "Speaker apagado";
        }
    }
}
