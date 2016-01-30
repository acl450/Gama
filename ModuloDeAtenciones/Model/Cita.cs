using System;

namespace Gama.Atenciones.Biz.Model
{
    public class Cita
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public bool HaTenidoLugar { get; set; }

        public string Asesor { get; set; }

        public string Sala { get; set; }

        // Puede ser nula
        public Atencion Atencion { get; set; }
    }
}