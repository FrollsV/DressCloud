using BusinessLogic.Forecast;
using BusinessLogic.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace MetaWeatherAPI
{
    public class MetaWeatherForecast
    {
        private IHttpClient m_HttpCLient;

        public MetaWeatherForecast(IHttpClient httpClient)
        {
            m_HttpCLient = httpClient;
        } 


        /// <summary>
        /// Method returned API response 
        /// </summary>
        /// <param name="city">user input from UI</param>
        /// <returns>returns the weather forecast for given city</returns>
        public Forecast GetWeatherForecast(string city)
        {
            string locationId = GetLocationIDByCity(city);
            Forecast weather = GetWeatherByLocationID(locationId);

            return weather;
        }
        private string GetLocationIDByCity(string city)
        {
            var response = m_HttpCLient.GetStringAsync("https://www.metaweather.com/api/location/search/?query=" + city);
            JArray locationResponse = (JArray)JsonConvert.DeserializeObject(response);
  
            return locationResponse[0]["woeid"].Value<string>();
        }

        private Forecast GetWeatherByLocationID(string woeid)
        {
            Forecast forecast = new Forecast();
            var response = m_HttpCLient.GetStringAsync("https://www.metaweather.com/api/location/" + woeid);
            dynamic weatherForecast = JObject.Parse(response);
            forecast.Temperature = (double)(weatherForecast.consolidated_weather[0]["the_temp"].Value);
            forecast.Condition = weatherForecast.consolidated_weather[0]["weather_state_name"].Value.ToString();
            return forecast;
            
        }

    }  
}
