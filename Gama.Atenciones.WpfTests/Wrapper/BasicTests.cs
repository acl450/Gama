﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gama.Atenciones.Wpf.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloDeAtenciones.Model;

namespace Gama.Atenciones.Wpf.Wrapper.Tests
{
    [TestClass()]
    public class BasicTests
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

        [TestMethod()]
        public void ShouldContainModelInModelProperty()
        {
            var wrapper = new PersonaWrapper(_persona);
            Assert.AreEqual(_persona, wrapper.Model);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullExceptionIfModelIsNull()
        {
            try
            {
                var wrapper = new PersonaWrapper(null);
            }
            catch(ArgumentNullException ex)
            {
                Assert.AreEqual("model", ex.ParamName);
                throw;
            }
        }

        [TestMethod]
        public void ShouldGetValueOfUnderlyingModelProperty()
        {
            var wrapper = new PersonaWrapper(_persona);
            Assert.AreEqual(_persona.Nombre, wrapper.Nombre);
        }

        [TestMethod]
        public void ShouldSetValueOfUnderlyingModelProperty()
        {
            var wrapper = new PersonaWrapper(_persona);
            wrapper.Nombre = "Julia";

            Assert.AreEqual("Julia", _persona.Nombre);
        }
    }
}