using BusinessLogic.ClothesPicker;
using BusinessLogic.ClothesPicker.Models;
using BusinessLogic.Forecast;
using Xunit;

namespace Tests.BusinessLogic.ClothesPickerTests
{
    public class ClothesPickerTest
    {
        [Fact]
        public void SuggestingToTakeUmbrellaInCaseOfRain()
        {
            ClothesPicker sut = new ClothesPicker();
            Forecast forecast = new Forecast
            {
                Condition = Forecast.RAIN
            };
            Outfit outfit = sut.DressMe(forecast);
            Assert.True(outfit.Accessories.Umbrella);
        }
    }
}
