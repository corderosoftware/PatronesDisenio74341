using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private DvdPlayer _DvdPlayer;
        private Proyector _Proyector;
        private Speakers _Speakers;

        public HomeTheaterFacade(DvdPlayer dvdPlayer,
            Proyector proyector,
            Speakers speakers)
        {
            _DvdPlayer = dvdPlayer;
            _Proyector = proyector;
            _Speakers = speakers;
        }
        public string WatchMovie(string movie)
        {
            var stringReturn = "Prepárate para ver una película...." + "\r\n";
            stringReturn += _Proyector.On() + "\r\n";
            stringReturn += _Speakers.On() + "\r\n";
            stringReturn += _DvdPlayer.On() + "\r\n";
            stringReturn += _DvdPlayer.PlayMovie(movie);

            return stringReturn;

        }
        public string EndMovie()
        {
            var stringReturn = "Cerrando el cine..." + "\r\n";
            stringReturn += _Proyector.Off() + "\r\n";
            stringReturn += _Speakers.Off() + "\r\n";
            stringReturn += _DvdPlayer.Off();

            return stringReturn;
        }
    }
}
