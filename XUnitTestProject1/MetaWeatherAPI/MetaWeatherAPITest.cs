using Xunit;
using MetaWeatherAPI;
using BusinessLogic.Forecast;

namespace Tests.MetaWeatherAPI
{
    public class MetaWeatherAPITest
    {
      [Fact]  
      public void GetWeatherForecastInPrague()
      {
            MetaWeatherForecast sut = new MetaWeatherForecast();
            Forecast forecast = new Forecast();
            forecast = sut.GetWeatherForecastByGivenCity();



      }
    }
}
