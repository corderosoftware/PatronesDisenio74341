using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Banco : ProcesoBusqueda
    {
        public override string RecibirCurriculum()
        {
            return "Receción de curriculums de los candidatos, en el Banco";
        }
        public override string EmitirOferta()
        {
            return "Se le hace llegar la oferta al candidato, desde el Banco";
        }

        public override string RealizarEntrevista()
        {
            return "Se realizan las entrevistas a los candidatos";
        }

    }
}
