using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gama.Atenciones.Biz.Util;

namespace Gama.Atenciones.Biz.Model
{
    #region Enumeraciones EstadoCivil, Orientacion, ...
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EstadoCivil
    {
        [Description("Casada/o")]
        Casada,
        [Description("Soltera/o")]
        Soltera,
        [Description("Divorciada/o")]
        Divorciada,
        [Description("Viuda/o")]
        Viuda,
        [Description("No proporcionado")]
        NoProporcionado
    };

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Orientacion
    {
        [Description("Heterosexual")]
        Heterosexual,
        [Description("Bisexual")]
        Bisexual,
        [Description("Lesbiana")]
        Lesbiana,
        [Description("Gay")]
        Gay,
        [Description("No proporcionado")]
        NoProporcionado
    };
    public enum ComoConocioAGama { RedInformal, RedFormal, Difusion };
    public enum ViaDeAccesoAGama { Personal, Email, Telefonica };
    public enum NivelAcademico { EstudiosPrimarios, EstudiosSecundarios };
    public enum Ocupacion { Ocupcion1, Ocupacion2 };
    #endregion

    public class Persona
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Nif { get; set; }
         
        public string Nacionalidad { get; set; }

        public DateTime? FechaDeNacimiento { get; set; } // Nullable

        public int NumeroDeAtendido { get; set; }

        public string EstadoCivil { get; set; }

        public string Orientacion { get; set; }

        public string Identidad { get; set; }

        public string ComoConocioAGama { get; set; }

        public string NivelAcademico { get; set; }

        public string Ocupacion { get; set; }

        public Direccion Direccion { get; set; }

        public List<Cita> Citas { get; set; }

        public byte[] Imagen { get; set; }
    }
}
