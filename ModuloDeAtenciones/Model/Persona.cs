using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeAtenciones.Model
{
    public class Persona
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Nif { get; set; }
         
        public string Nacionalidad { get; set; }

        public Direccion Direccion { get; set; }

        public DateTime? FechaDeNacimiento { get; set; } // Nullable

        public int NumeroDeAtendido { get; set; }

        public string EstadoCivil { get; set; }

        public string Orientacion { get; set; }

        public string Identidad { get; set; }

        public string ComoConocioAGama { get; set; }

        public string NivelAcademico { get; set; }

        public string Ocupacion { get; set; }

        public List<Cita> Citas { get; set; }
    }
}
