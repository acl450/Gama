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
        [Description("No proporcionado")]
        NoProporcionado,
        [Description("Casada/o")]
        Casada,
        [Description("Soltera/o")]
        Soltera,
        [Description("Divorciada/o")]
        Divorciada,
        [Description("Viuda/o")]
        Viuda
    };

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Orientacion
    {
        [Description("No proporcionado")]
        NoProporcionado,
        [Description("Heterosexual")]
        Heterosexual,
        [Description("Bisexual")]
        Bisexual,
        [Description("Lesbiana")]
        Lesbiana,
        [Description("Gay")]
        Gay
    };

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum IdentidadSexual
    {
        [Description("No proporcionado")]
        NoProporcionado,
        [Description("Hombre")]
        Hombre,
        [Description("Mujer")]
        Mujer,
        [Description("Hombre transgénero")]
        HombreTransgenero,
        [Description("Mujer transgénero")]
        MujerTransgenero
    };

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ComoConocioAGama
    {
        [Description("No proporcionado")]
        NoProporcionado,
        [Description("Red Informal")]
        RedInformal,
        [Description("Red Formal")]
        RedFormal,
        [Description("Difusión")]
        Difusion
    };

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ViaDeAccesoAGama
    {
        [Description("No proporcionado")]
        NoProporcionado,
        [Description("Personal")]
        Personal,
        [Description("Email")]
        Email,
        [Description("Telefonica")]
        Telefonica
    };

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum NivelAcademico
    {
        [Description("No proporcionado")]
        NoProporcionado,
        [Description("Estudios Primarios")]
        EstudiosPrimarios,
        [Description("Estudios Secundarios")]
        EstudiosSecundarios,
        [Description("Estudios Superiores")]
        EstudiosSuperiores
    };

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Ocupacion
    {
        [Description("No proporcionado")]
        NoProporcionado
    };
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

        public EstadoCivil EstadoCivil { get; set; }

        public Orientacion Orientacion { get; set; }

        public IdentidadSexual Identidad { get; set; }

        public ComoConocioAGama ComoConocioAGama { get; set; }

        public NivelAcademico NivelAcademico { get; set; }

        public Ocupacion Ocupacion { get; set; }

        public Direccion Direccion { get; set; }

        public List<Cita> Citas { get; set; }

        public byte[] Imagen { get; set; }
    }
}
