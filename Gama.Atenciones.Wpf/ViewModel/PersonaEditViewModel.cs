using Común;
using GalaSoft.MvvmLight;
using Gama.Atenciones.Wpf.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.ViewModel
{
    public interface IPersonaEditViewModel
    {
        void Load(int? personaId = null);
        PersonaWrapper Persona { get; }
    }

    public class PersonaEditViewModel : Observable, IPersonaEditViewModel
    {
        public PersonaWrapper Persona
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Load(int? personaId = default(int?))
        {
            throw new NotImplementedException();
        }
    }


}
