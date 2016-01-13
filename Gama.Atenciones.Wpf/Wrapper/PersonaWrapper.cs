using Común;
using ModuloDeAtenciones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.Wrapper
{
    public class PersonaWrapper : Observable
    {
        public PersonaWrapper(Persona model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            this.Model = model;
        }

        public Persona Model { get; set; }

        public string Nombre
        {
            get { return this.Model.Nombre; }
            set
            {
                if (!Equals(this.Model.Nombre, value))
                {
                    this.Model.Nombre = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
