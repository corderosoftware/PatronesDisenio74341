using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class ProcesoBusqueda
    {
        public abstract string RecibirCurriculum();
        public abstract string RealizarEntrevista();

        //Las clases concretas lo pueden omitir o lo sobreescriben.
        public virtual string RealizarPruebaTecnica()
        {
            return string.Empty;
        }
        public abstract string EmitirOferta();

        //Template Method
        public List<string> ContratarCandidato()
        {
            //RecibirCurriculum();
            //RealizarEntrevista();
            //RealizarPruebaTecnica();
            //EmitirOferta();
            List<string> Actividades = [];
            
            Actividades.Add(RecibirCurriculum());
            Actividades.Add(RealizarEntrevista());
            Actividades.Add(RealizarPruebaTecnica());
            Actividades.Add(EmitirOferta());

            return Actividades;

        }
    }
}
