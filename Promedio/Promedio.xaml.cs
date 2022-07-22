using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Promedio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Promedio : ContentPage
    {
        double nota1;
        double nota2;
        double nota3;
        double promedio;

        public Promedio()
        {
            InitializeComponent();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            promedio = ((nota1 + nota2 + nota3) / 3);
            lblpromedio.Text = promedio.ToString();
            if (promedio < 14)
            {
              
                DisplayAlert("Promedios", "Su promedio es " + promedio.ToString() + " Esta Reprobado", "OK");
            }
            else
            {
                
                DisplayAlert("Promedios", "Su promedio es " + promedio.ToString() + " Esta Aprobado ", "OK");

            }
        }

        private void btnregresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}