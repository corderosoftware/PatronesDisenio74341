﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability;
public class DirectorHandler : AprobadorHandler
{
    public override void ProcesarSolicitud(Compra compra)
    {
        //La lógica de negocio
        if (compra.Monto <= 10000)
        {
            MessageBox.Show($"{this.GetType().Name} Solicitud Nro {compra.Numero} aprobada.");
        }
        else if (_sucesor != null) {
            _sucesor.ProcesarSolicitud(compra);
        }
    }
}
