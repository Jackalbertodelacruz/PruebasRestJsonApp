using PruebaTecMovilREST.Models;
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
	public partial class MainPage : MasterDetailPage
    {
		public MainPage ()
		{
			InitializeComponent ();
            Master = masterPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MenuPrincipal)));
            masterPage.ListView.ItemSelected += OnItemSelected;
            MasterBehavior = MasterBehavior.Popover;
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

        async void SalirClicked(object sender, EventArgs e)
        {
            //App.IsUserLoggedIn = false;
            LoginPage log = new LoginPage();

            //await Navigation.PushModalAsync(log);

            await Navigation.PopModalAsync();
            ////Navigation.RemovePage(this);
            //Navigation.InsertPageBefore(new LoginPage(), this);

            //var poppedPage = await Navigation.PopModalAsync();

        }
    }
}