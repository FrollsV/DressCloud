using BusinessLogic.ClothesPicker.Models;

namespace BusinessLogic.ClothesPicker
{
    public class ClothesPicker
    {
        public Outfit DressMe(Forecast.Forecast forecast) {

            Outfit outfit = new Outfit();
            if (forecast.Condition == Forecast.Forecast.RAIN)
            {
                outfit.Accessories.Umbrella = true;
            }
            return outfit;
        }
    }

}
