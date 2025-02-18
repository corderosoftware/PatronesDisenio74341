using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DvdPlayer
    {
        public string On()
        {
            return "DVD Player encendido";
        }
        public string Off()
        {
            return "DVD Player apagado";
        }
        public string PlayMovie(string movie)
        {
            return $"Reproduciendo la Pelicula: {movie}";
        }
    }
}
