using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BlazorCovid19Application.Client.API
{
    public class HelperAPI
    {
        //HttpClient kütüphanesini/nesnesini/sınıfını kullanarak bir external web API'ı çağırabiliriz. 
        public static HttpClient ApiClient { get; set; }

        public static void InitializedClient()
        {
            ApiClient = new HttpClient(); 
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Accept header'ını "application/json" olarak ayarlar. Sunucuya verileri JSON biçiminde göndermesini bildirir.

        }

    }
}
