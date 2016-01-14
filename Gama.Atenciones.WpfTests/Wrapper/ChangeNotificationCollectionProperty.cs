using Gama.Atenciones.Wpf.Wrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gama.Atenciones.Biz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.WpfTests.Wrapper
{
    [TestClass]
    public class ChangeNotificationCollectionProperty
    {
        private Persona _persona;
        private Cita _cita;

        [TestInitialize]
        public void Initialize()
        {
            _cita = new Cita
            {
                Fecha = DateTime.Now.AddYears(-15)
            };

            _persona = new Persona
            {
                Nombre = "Thomas",
                Direccion = new Direccion(),
                Citas = new List<Cita>
                {
                    new Cita { Fecha = DateTime.Now },
                    _cita
                }
            };
        }

        [TestMethod]
        public void ShouldInitializeCitasProperty()
        {
            var wrapper = new PersonaWrapper(_persona);
            Assert.IsNotNull(wrapper.Citas);
            CheckIfModelCitasCollectionIsInSync(wrapper);
        }

        [TestMethod]
        public void ShouldBeInSyncAfterAddingCita()
        {
            _persona.Citas.Remove(_cita);
            var wrapper = new PersonaWrapper(_persona);
            wrapper.Citas.Add(new CitaWrapper(_cita));
            CheckIfModelCitasCollectionIsInSync(wrapper);
        }

        [TestMethod]
        public void ShouldBeInSyncAfterRemovingCita()
        {
            var wrapper = new PersonaWrapper(_persona);
            var citaToRemove = wrapper.Citas.Single(w => w.Model == _cita);
            wrapper.Citas.Remove(citaToRemove);
            CheckIfModelCitasCollectionIsInSync(wrapper);
        }

        private void CheckIfModelCitasCollectionIsInSync(PersonaWrapper wrapper)
        {
            Assert.AreEqual(_persona.Citas.Count, wrapper.Citas.Count);
            Assert.IsTrue(_persona.Citas.All(c => wrapper.Citas.Any(w => w.Model == c)));
        }
    }
}
