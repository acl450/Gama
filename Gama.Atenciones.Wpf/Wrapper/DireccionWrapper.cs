using ModuloDeAtenciones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.Wrapper
{
    public class DireccionWrapper : ModelWrapper<Direccion>
    {
        public DireccionWrapper(Direccion modelo) : base(modelo)
        {
        }

        public int Id
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string Calle
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Ciudad
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Isla
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
