using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Sum_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int result = n1 + n2;
                await Navigation.PushModalAsync(new Resultados(result));
            }
            else
            {
                DisplayAlert("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }

        private async void Rest_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resultado = n1 - n2;
                await Navigation.PushModalAsync(new Resultados(resultado));
            }
            else
            {
                DisplayAlert("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }

        private async void Multiplic_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {

                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resultado = n1 * n2;
                await Navigation.PushModalAsync(new Resultados(resultado));
            }
            else
            {
                DisplayAlert("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }

        private async void Divid_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(num1.Text) && !String.IsNullOrWhiteSpace(num2.Text))
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resultado = n1 / n2;
                await Navigation.PushModalAsync(new Resultados(resultado));
            }
            else
            {
                DisplayAlert("Advertencia", "Llene Ambos Campos para Continuar", "Cerrar");
            }
        }
    }
}
