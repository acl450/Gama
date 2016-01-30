using Gama.Atenciones.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Gama.Atenciones.Wpf.Controles
{
    public class BuscadorDePersonasDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is string)
                return Application.Current.Resources["EsperarResultadoDeBusquedaDataTempalte"] as DataTemplate;
            else
                return Application.Current.Resources["ResultadoDeBusquedaDataTempalte"] as DataTemplate;
        }
    }
}
