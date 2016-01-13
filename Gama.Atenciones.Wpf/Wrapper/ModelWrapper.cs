using Común;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Atenciones.Wpf.Wrapper
{
    public class ModelWrapper<T> : Observable
    {
        public ModelWrapper(T model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            this.Model = model;
        }

        public T Model { get; private set; }

        protected TValue GetValue<TValue>([CallerMemberName] string propertyName = null)
        {
            var propertyInfo = this.Model.GetType().GetProperty(propertyName);
            return (TValue)propertyInfo.GetValue(this.Model);
        }

        protected void SetValue<TValue>(TValue value, [CallerMemberName] string propertyName = null)
        {
            var propertyInfo = this.Model.GetType().GetProperty(propertyName);
            var currentValue = propertyInfo.GetValue(Model);

            if (!Equals(currentValue, value))
            {
                propertyInfo.SetValue(this.Model, value);
                OnPropertyChanged(propertyName);
            }
        }

        protected void RegisterCollection<TWrapper, TModel>(
            ObservableCollection<TWrapper> wrapperCollection,
            List<TModel> modelCollection) where TWrapper : ModelWrapper<TModel>
        {
            wrapperCollection.CollectionChanged += (s, e) => {
                if (e.OldItems != null)
                {
                    foreach (var item in e.OldItems.Cast<TWrapper>())
                    {
                        modelCollection.Remove(item.Model);
                    }
                }

                if (e.NewItems != null)
                {
                    foreach (var item in e.NewItems.Cast<TWrapper>())
                    {
                        modelCollection.Add(item.Model);
                    }
                }
            };
        }
    }
}
