using Gama.Atenciones.Wpf.Wrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuloDeAtenciones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.WpfTests.Wrapper
{
    [TestClass]
    public class ChangeNotificationSimpleProperty
    {
        private Persona _persona;

        [TestInitialize]
        public void Initilize()
        {
            _persona = new Persona
            {
                Nombre = "Thomas",
                Citas = new List<Cita>()
            };
        }

        [TestMethod]
        public void ShouldRaisePropertyChangedEventOnPropertyChange()
        {
            var fired = false;
            var wrapper = new PersonaWrapper(_persona);

            // (object sender, System.ComponentModel.PropertyChangedEventArgs e)
            wrapper.PropertyChanged += (s, e) => 
            {
                if (e.PropertyName == "Nombre")
                {
                    fired = true;
                }
            };

            wrapper.Nombre = "Julia";
            Assert.IsTrue(fired);
        }

        [TestMethod]
        public void ShouldNotRaisePropertyChangedEventIfPropertyIsSetToSameValue()
        {
            var fired = false;
            var wrapper = new PersonaWrapper(_persona);

            wrapper.PropertyChanged += (s, e) => 
            {
                if (e.PropertyName == "Nombre")
                {
                    fired = true;
                }
            };

            wrapper.Nombre = "Thomas";
            Assert.IsFalse(fired);
        }
    }
}
