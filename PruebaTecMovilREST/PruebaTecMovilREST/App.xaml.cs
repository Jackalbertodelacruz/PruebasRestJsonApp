using PruebaTecMovilREST.Views;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PruebaTecMovilREST
{
    public partial class App : Application
    {
        public static HttpClient RestClient { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();


            //App.RestClient = new HttpClient(new Dictionary<string, string> , new Dictionary<string, string>
            //{
            //    { "X-API-Key", "BLUMONPAY"},    
            //    { "X-API-Key", "BLUMONPAY"}
            //});

            //App.RestClient.GetAsync<List<WGResult>> ("http://blumonpay.biz/BancaMifel/Pruebas/login_test");

            //var mainpage = await _client.Get<WGResult>("http://blumonpay.biz/BancaMifel/Pruebas/login_test");



        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
