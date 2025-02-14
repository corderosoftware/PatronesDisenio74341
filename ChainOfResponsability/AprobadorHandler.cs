using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability;
public abstract class AprobadorHandler
{
    protected AprobadorHandler _sucesor;

    public void SetSucesor(AprobadorHandler sucesor)
    {
        _sucesor = sucesor;
    }

    public abstract string ProcesarSolicitud(Compra compra);

}
