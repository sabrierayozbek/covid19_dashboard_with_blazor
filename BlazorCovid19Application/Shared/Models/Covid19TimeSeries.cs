using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace BlazorCovid19Application.Shared.Models
{
    public class Covid19TimeSeries
    {
        public partial class GeneralInfos
        {
            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("province")]
            public object Province { get; set; }

            [JsonProperty("timeline")]
            public Timeline Timeline { get; set; }
        }

        public partial class Timeline
        {
            [JsonProperty("cases")]
            public Dictionary<string, long> Cases { get; set; }

            [JsonProperty("deaths")]
            public Dictionary<string, long> Deaths { get; set; }

            [JsonProperty("recovered")]
            public Dictionary<string, long> Recovered { get; set; }
        }

        public long countTotalDeaths { get; set; }
        public long countTotalCases { get; set; }
        public long countTotalRecover { get; set; }
        public string countries { get; set; }
        public Dictionary<string, long> TotalCases { get; set; }
        
        public Dictionary<string, long> TotalDeaths { get; set; }

        public Dictionary<string, long> TotalRecovered { get; set; }


    }
}
