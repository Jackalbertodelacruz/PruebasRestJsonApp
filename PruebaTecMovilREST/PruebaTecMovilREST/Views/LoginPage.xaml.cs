using Newtonsoft.Json;
using PruebaTecMovilREST.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaTecMovilREST.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
       
        public LoginPage()
        {
            InitializeComponent();
        }

        public void btnClick(object sender, EventArgs e)
        {

            // MPostAsync();
            MainPage main = new MainPage();
            Navigation.PushModalAsync(main);
        }

        public async void MPostAsync()
        {
            string url = "http://blumonpay.biz/BancaMifel/Pruebas/login_test";
          

            string myJson = "{'Usuario':'asd','Contrasena':'123'}";

            var obj = new Login { User = "login", Pass = "din@gmail.com" };
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            string json2 = await Task.Run(() => JsonConvert.SerializeObject(obj, Formatting.Indented));

            var httpContent = new StringContent(myJson, Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                // Error here 
                var httpResponse = await httpClient.PostAsync(url, httpContent);
                if (httpResponse.Content != null)
                {
                    // Error Here 
                    var responseContent = await httpResponse.Content.ReadAsStringAsync();
                    lblMensaje.Text = responseContent;
                }
            }

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://example.com/");
            //client.DefaultRequestHeaders
            //      .Accept
            //      .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "relativeAddress");
            //request.Content = new StringContent("{\"name\":\"John Doe\",\"age\":33}",
            //                                    Encoding.UTF8,
            //                                    "application/json");


            //var request = (HttpWebRequest)WebRequest.Create(url);
            //request.ContentType = "application/json";
            //request.Method = "POST";



            //using (var client = new HttpClient())
            //{
            //    var response = await client.PostAsync(
            //        url,
            //         new StringContent("{\"Usuario\":\"Doe\",\"Contrasena\":33}", Encoding.UTF8, "application/json"));
            //    lblMensaje.Text = await response.Content.ReadAsStringAsync();
                
            //}






            //HttpResponseMessage response = null;
            //try
            //{
            //    using (var client = new HttpClient())
            //    {
            //        response = client.PostAsync(
            //         url,
            //          new StringContent(json, Encoding.UTF8, "application/json")).Result;
            //        if (response.IsSuccessStatusCode)
            //        {
            //            lblMensaje.Text = response.StatusCode.ToString();
            //        }
            //        else
            //        {
            //            lblMensaje.Text = "NO OK";
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    lblMensaje.Text = "Error";
            //}




            //var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";
            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string json2 = "{\"Usuario\":\"test\"," +
            //                  "\"Contrasena\":\"bla\"}";
            //    streamWriter.Write(json2);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //    lblMensaje.Text = result;
            //}



            //var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";
            //using (var streamWriter = new

            //StreamWriter(httpWebRequest.GetRequestStream()))
            //{

            //    streamWriter.Write(new StringContent(myJson, Encoding.UTF8, "application/json"));
            //}
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //    lblMensaje.Text = result.ToString();
            //}




            //var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";
            //using (var streamWriter = new

            //StreamWriter(httpWebRequest.GetRequestStream()))
            //{

            //    streamWriter.Write(json);
            //}
            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //    lblMensaje.Text = result;
            //}


            //using (HttpClient client = new HttpClient())
            //{
            //    using (HttpResponseMessage response = await client.PostAsync(url, new StringContent(myJson, Encoding.UTF8, "application/json")))
            //    {

            //        using (HttpContent content = response.Content)
            //        {
            //            string   = await content.ReadAsStringAsync();
            //            lblMensaje.Text = MyContent;
            //        }
            //    }
            //}
        }

        
        }
}