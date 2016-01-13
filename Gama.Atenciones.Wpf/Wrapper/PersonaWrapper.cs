using Común;
using ModuloDeAtenciones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.Wrapper
{
    public class PersonaWrapper : ModelWrapper<Persona>
    {
        public PersonaWrapper(Persona model) : base(model)
        {
        }

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
