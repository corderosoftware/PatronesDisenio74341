using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class SoftwareFactory : ProcesoBusqueda
    {
        public override string RecibirCurriculum()
        {
            return "Recepción de curriculums de los candidatos, en la Consultora";
        }
        public override string EmitirOferta()
        {
            return "Se le hace llegar la oferta al candidato, desde la Consultora";
        }

        public override string RealizarEntrevista()
        {
            return "Se realizan las entrevistas a los candidatos";
        }

        public override string RealizarPruebaTecnica() //Aqui si hay prueba tecnica
        {
            return "Se realiza el test de conocnimiento técnico";
        }
    }
}
