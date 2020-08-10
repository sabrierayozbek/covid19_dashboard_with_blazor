using BlazorCovid19Application.Client.API;
using BlazorCovid19Application.Shared;
using BlazorCovid19Application.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCovid19Application.Client.Services
{
    public class APIServices
    {
        public APIServices()
        {
            HelperAPI.InitializedClient();
        }

        public async Task<List<Covid19InfoDTO>> CovidInfoData()
        {
            try
            {
                APIActions apiActions = new APIActions();
                return await apiActions.LoadAllCountriesData();
            }
            catch (Exception)
            {
                return null;
            }
        }


        public async Task<List<Covid19TimeSeries>> CountriesInfoData()
        {
            try
            {
                APIActions apiActions = new APIActions();
                return await apiActions.LoadAllCountriesInfo();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Covid19InfoDTO> TurkeyCovidInfoData()
        {
            try
            {
                APIActions ApiProcessor = new APIActions();
                return await ApiProcessor.TurkeyData();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<WorldWideInfoDTO> AroundTheWorld()
        {
            try
            {
                APIActions ApiProcessor = new APIActions();
                return await ApiProcessor.WorldWideAffected();
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
