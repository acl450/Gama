using Gama.Atenciones.Biz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.Wrapper
{
    public class AtencionWrapper : ModelWrapper<Atencion>
    {
        public AtencionWrapper(Atencion model) : base(model)
        {
        }

        public int NumeroDeExpediente
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public DateTime Fecha
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public string Seguimiento
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public bool EsSocial
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsJuridica
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsPsicologica
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsDeAcogida
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsDeOrientacionLaboral
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsDePrevencionParaLaSalud
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsDeFormacion
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsDeParticipacion
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool EsOtra
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public string Otra
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
