using ModuloDeAtenciones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.Wrapper
{
    public class PersonaWrapper
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
    }
}
