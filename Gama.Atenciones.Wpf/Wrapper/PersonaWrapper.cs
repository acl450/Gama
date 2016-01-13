﻿using Común;
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
            InitializeComplexProperties(model);
        }

        private void InitializeComplexProperties(Persona model)
        {
            if (model.Direccion == null)
            {
                throw new ArgumentException("La dirección no puede ser nula");
            }

            this.Direccion = new DireccionWrapper(model.Direccion);
        }

        public string Nombre
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Email
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public string Nif
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Nacionalidad
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public DateTime? FechaDeNacimiento
        {
            get { return GetValue<DateTime?>(); }
            set { SetValue(value); }
        }

        public int NumeroDeAtendido
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string EstadoCivil
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Orientacion
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Identidad
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string ComoConocioAGama
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string NivelAcademico
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Ocupacion
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public DireccionWrapper Direccion { get; private set; }
    }
}
