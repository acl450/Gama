using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Biz.Model
{
    public class Atencion
    {
        public int Id { get; set; }
       
        public int NumeroDeExpediente { get; set; }

        public DateTime Fecha { get; set; }

        public string Seguimiento { get; set; }

        public bool EsSocial { get; set; }

        public bool EsJuridica { get; set; }

        public bool EsPsicologica { get; set; }

        public bool EsDeAcogida { get; set; }

        public bool EsDeOrientacionLaboral { get; set; }

        public bool EsDePrevencionParaLaSalud { get; set; }

        public bool EsDeFormacion { get; set; }

        public bool EsDeParticipacion { get; set; }

        public bool EsOtra { get; set; }

        public string Otra { get; set; }
    }                  
}
