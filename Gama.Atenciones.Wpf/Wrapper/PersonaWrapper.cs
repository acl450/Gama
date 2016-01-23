using Común;
using Gama.Atenciones.Biz.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            InitializeCollectionProperties(model);
        }

        private void InitializeCollectionProperties(Persona model)
        {
            if (model.Citas == null)
            {
                throw new ArgumentException("Citas no puede ser nulo");
            }

            this.Citas = new ObservableCollection<CitaWrapper>(
                model.Citas.Select(c => new CitaWrapper(c)));

            RegisterCollection(Citas, model.Citas);
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

        public EstadoCivil EstadoCivil
        {
            get { return GetValue<EstadoCivil>(); }
            set { SetValue(value); }
        }

        public Orientacion Orientacion
        {
            get { return GetValue<Orientacion>(); }
            set { SetValue(value); }
        }

        public IdentidadSexual Identidad
        {
            get { return GetValue<IdentidadSexual>(); }
            set { SetValue(value); }
        }

        public ComoConocioAGama ComoConocioAGama
        {
            get { return GetValue<ComoConocioAGama>(); }
            set { SetValue(value); }
        }

        public NivelAcademico NivelAcademico
        {
            get { return GetValue<NivelAcademico>(); }
            set { SetValue(value); }
        }

        public Ocupacion Ocupacion
        {
            get { return GetValue<Ocupacion>(); }
            set { SetValue(value); }
        }

        public DireccionWrapper Direccion { get; private set; }

        public ObservableCollection<CitaWrapper> Citas { get; private set; }
    }
}
