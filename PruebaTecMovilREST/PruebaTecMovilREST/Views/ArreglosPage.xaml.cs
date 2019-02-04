using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaTecMovilREST.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ArreglosPage : ContentPage
	{
		public ArreglosPage ()
		{
			InitializeComponent ();
		}

        int[] array = new int[3];

        public void IniciarSuma()
        {
            lbld1.Text = SumDerIzq().ToString();
            lblD2.Text = SumIzqDer().ToString();
        }

        public int SumDerIzq()
        {

            int resul = 0;
            try
            {
                if (a1.Text != null || ab.Text != null || a3.Text != null)
                {
                    resul = int.Parse(a1.Text) + int.Parse(ab.Text) + int.Parse(a3.Text);
                }
                else { DisplayAlert("Error", "Variables nulas", "OK"); }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error","Variables incorrectas","OK");
            }

            return resul;
        }

        public int SumIzqDer()
        {
            int resul = 0;
            try
            {
                if (b3.Text != null || ab.Text != null || b1.Text != null)
                {
                    resul = int.Parse(b3.Text) + int.Parse(ab.Text) + int.Parse(b1.Text);
                }
                else { DisplayAlert("Error","Variables nulas", "OK"); }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Variables incorrectas", "OK");
            }

            return resul;
        }

        public void btnSolucion(Object sender, EventArgs e)
        {
            IniciarSuma();
        }
    }
}