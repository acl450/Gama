using Común;
using ModuloDeAtenciones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
