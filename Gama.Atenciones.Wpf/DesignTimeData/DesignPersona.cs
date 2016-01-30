using Gama.Atenciones.Biz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Enums = Gama.Atenciones.Biz.Model;

namespace Gama.Atenciones.Wpf.DesignTimeData
{
    public class DesignPersona : Persona 
    {
        public DesignPersona()
        {
            this.Nombre = "Gustavo Adolfo Bécquer";
            this.Email = "GustavoAdolfo@gmail.com";
            this.Nif = "00000000T";
            this.Nacionalidad = "Español";
            this.FechaDeNacimiento = DateTime.Now;
            this.NumeroDeAtendido = 1;
            this.EstadoCivil = Enums.EstadoCivil.Casada;
            this.Orientacion = Enums.Orientacion.Lesbiana;
            this.Identidad = Enums.IdentidadSexual.MujerTransgenero;
            this.ComoConocioAGama = Enums.ComoConocioAGama.Difusion;
            this.NivelAcademico = Enums.NivelAcademico.EstudiosSuperiores;
            this.Ocupacion = Enums.Ocupacion.NoProporcionado;
            this.Direccion = new Direccion
            {
                Calle = "C/ Bethencourt Arrocha 47, 2ºB",
                Ciudad = "Las Palmas de Gran Canaria",
                Isla = "Gran Canaria"
            };

            this.Citas = new List<Cita>();

            SetImageProperty();
        }

        private void SetImageProperty()
        {
            var streamResourceInfo =
                Application.GetResourceStream(
                    new Uri("pack://application:,,,/Gama.Atenciones.Wpf;component/DesignTimeData/Images/user-128.png"));
                    //new Uri("/DesignTimeData/Images/user-128.png", UriKind.Relative));

            var length = streamResourceInfo.Stream.Length;
            byte[] image = new byte[length];
            streamResourceInfo.Stream.Read(image, 0, (int)length);

            this.Imagen = image;
        }
    }
}
