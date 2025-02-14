using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability;
public class DirectorHandler : AprobadorHandler
{
    public override string ProcesarSolicitud(Compra compra)
    {
        //La lógica de negocio
        return string.Empty;
    }
}
