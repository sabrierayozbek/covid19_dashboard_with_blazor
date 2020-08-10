using BlazorCovid19Application.Shared;
using BlazorCovid19Application.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorCovid19Application.Client.API
{
    public class APIActions
    {
        public async Task<List<Covid19InfoDTO>> LoadAllCountriesData()
        {
            try
            {
                //using bloğu kullanarak dispose edilecek nesneleri otomatik olarak dispose ettirebiliyoruz.
                //API'ımızı kullanabilmek için gerekli linki tanımladık. HTTP isteği için hazır hale getirdik.

                string url = "https://disease.sh/v3/covid-19/countries";
                using (HttpResponseMessage response = await HelperAPI.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //GetAsync yöntemi HTTP GET isteğini gönderir. Yöntem tamamlandığında, HTTP yanıtını içeren bir HttpResponseMessage döndürür. 
                        //Yanıttaki durum kodu bir başarı koduysa, yanıt gövdesi bir ürünün JSON temsilini içerir. 
                        //Deserialization bir verinin transfer edilirkenki varolan iki byte'lık formunu bir stream Akış formunda çevirmesi olayıdır.
                        //Nesne, Deserialize edildiğinde ise nesnenin tam bir kopyası oluşturulur ve kullanıma sunulur.
                        //ReadAsAsync metodu ile veriyi deserialize ediyoruz.
                        //IsSuccessStatusCode, HTTP yanıtının durumunu bildirir.
                        var data = await response.Content.ReadAsAsync<List<Covid19InfoDTO>>();
                        await Task.Delay(200);
                        return data;
                    }

                    else
                    {
                        //Server'ın durumununun hangi hatadan kaynaklı olduğunu fırlat.
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {

                return null;
            }
        }


        public async Task<List<Covid19TimeSeries>> LoadAllCountriesInfo()
        {
            try
            {
                //using bloğu kullanarak dispose edilecek nesneleri otomatik olarak dispose ettirebiliyoruz.
                //API'ımızı kullanabilmek için gerekli linki tanımladık. HTTP isteği için hazır hale getirdik.

                string url = "https://disease.sh/v3/covid-19/historical?lastdays=all";
                using (HttpResponseMessage response = await HelperAPI.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //GetAsync yöntemi HTTP GET isteğini gönderir. Yöntem tamamlandığında, HTTP yanıtını içeren bir HttpResponseMessage döndürür. 
                        //Yanıttaki durum kodu bir başarı koduysa, yanıt gövdesi bir ürünün JSON temsilini içerir. 
                        //Deserialization bir verinin transfer edilirkenki varolan iki byte'lık formunu bir stream Akış formunda çevirmesi olayıdır.
                        //Nesne, Deserialize edildiğinde ise nesnenin tam bir kopyası oluşturulur ve kullanıma sunulur.
                        //ReadAsAsync metodu ile veriyi deserialize ediyoruz.
                        //IsSuccessStatusCode, HTTP yanıtının durumunu bildirir.
                        var data = await response.Content.ReadAsAsync<List<Covid19TimeSeries>>();
                        await Task.Delay(200);
                        return data;
                    }

                    else
                    {
                        //Server'ın durumununun hangi hatadan kaynaklı olduğunu fırlat.
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<Covid19InfoDTO> TurkeyData()
        {
            try
            {
                string url = "https://disease.sh/v3/covid-19/countries?yesterday=false";
                using (HttpResponseMessage response = await HelperAPI.ApiClient.GetAsync(url)) {

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsAsync<List<Covid19InfoDTO>>();
                        await Task.Delay(200);
                        var bddata = data.Where(c => c.Country.ToLower() == "turkey").FirstOrDefault();
                        return bddata;
                    }
                   
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            catch (Exception)
            {

                return null;
            }
        }

        public async Task<WorldWideInfoDTO> WorldWideAffected()
        {
            try
            {

                string url = "https://disease.sh/v2/all?yesterday=true&allowNull=false";
                using (HttpResponseMessage response = await HelperAPI.ApiClient.GetAsync(url))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsAsync<WorldWideInfoDTO>();
                        await Task.Delay(200);
                        return data;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }


    }
}
