﻿using Gama.Atenciones.Biz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.Wrapper
{
    public class CitaWrapper : ModelWrapper<Cita>
    {
        public CitaWrapper(Cita model) : base(model)
        {
            InitializeComplexProperties(model);
        }

        private void InitializeComplexProperties(Cita model)
        {
            if (model.Atencion == null)
            {
                throw new ArgumentException("La atención no puede ser nula");
            }

            this.Atencion = new AtencionWrapper(model.Atencion);
        }

        public DateTime Fecha
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public bool HaTenidoLugar
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public string Asesor
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Sala
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public AtencionWrapper Atencion { get; private set; }
    }
}
