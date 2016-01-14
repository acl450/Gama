using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gama.Atenciones.Biz.Model;
using Gama.Atenciones.Wpf.Wrapper;
using System.Collections.Generic;

namespace Gama.Atenciones.WpfTests.Wrapper
{
    [TestClass]
    public class ChangeNotificationComplexProperty
    {
        private Persona _persona;

        [TestInitialize]
        public void Initilize()
        {
            _persona = new Persona
            {
                Nombre = "Thomas",
                Direccion = new Direccion(),
                Citas = new List<Cita>()
            };
        }

        [TestMethod]
        public void ShouldInitializeAddressProperty()
        {
            var wrapper = new PersonaWrapper(_persona);
            Assert.IsNotNull(wrapper.Direccion);
            Assert.AreEqual(_persona.Direccion, wrapper.Direccion.Model);
        }
    }
}
