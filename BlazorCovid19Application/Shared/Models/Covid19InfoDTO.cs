using BlazorCovid19Application.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCovid19Application.Shared
{
    public class Covid19InfoDTO
    {
        //Bu sınıf, web API'sı tarafından kullanılan veri modeliyle eşleşir.
        //HttpClient ile bize HTTP responsundan dönen bilgileri okuyacağımız property'ler.
        public string Country { get; set; }
        public string Cases { get; set; }
        public string TodayCases { get; set; }
        public string Deaths { get; set; }
        public string TodayDeaths { get; set; }
        public string Recovered { get; set; }
        public string TodayRecovered { get; set; }
        public string Active { get; set; }
        public string Critical { get; set; }
        public string CasesPerOneMillion { get; set; }
        public string DeathsPerOneMillion { get; set; }
        public string Tests { get; set; }
        public string TestsPerOneMillion { get; set; }
        public long countCases { get; set; }
        public long countDeaths { get; set; }
        public long countRecover { get; set; }
        public long countTotalDeaths { get; set; }
        public long countTotalCases { get; set; }
        public long countTotalRecover { get; set; }
        public string countries { get; set; }

    }
}
