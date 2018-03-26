using BusinessLogic.Forecast;

namespace MetaWeatherAPI
{
    public class MetaWeatherForecast
    {

        public Forecast GetWeatherForecastByGivenCity()
        {
            string locationId = GetLocationIDByCity();
            string weather = GetWeatherByLocationID();



            return null;
        }
        private string GetLocationIDByCity()
        {

            return "";
        }

        private string GetWeatherByLocationID()
        {
            return "";
        }

    }
}

//System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
//var response = client.GetStringAsync("http://www.fuckme.now").GetAwaiter().GetResult();
