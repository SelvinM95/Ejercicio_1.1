using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultados : ContentPage
    {
        public Resultados(int resultado)
        {
            InitializeComponent();
            Resultado.Text = Convert.ToString(resultado);
        }
    }
}