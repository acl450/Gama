using System;

namespace ModuloDeAtenciones.Model
{
    public class Cita
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public bool HaTenidoLugar { get; set; }

        public string Asesor { get; set; }

        public string Sala { get; set; }
    }
}