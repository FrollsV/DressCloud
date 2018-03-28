using MetaWeatherAPI;
using BusinessLogic.Http;
using BusinessLogic.Forecast;
using Xunit;

namespace Tests.MetaWeatherAPI
{
    public class IntegrationTest
    {
        [Fact]
        public void GetActualAPICall()
        {

            IHttpClient client = new MyHttpClient();
            MetaWeatherForecast sut = new MetaWeatherForecast(client);
            Forecast forecast;
            forecast = sut.GetWeatherForecast("prague");
            Assert.False(string.IsNullOrEmpty(forecast.Condition));

        }
        

    }
}
