

namespace WinFrom_FF.Helpers
{
    public class PriceConfiguration
    {
        public static bool IsCorrectPriceRelation(double price, double costPrice, double discount)
        {
            return price >= costPrice && price >= discount;
        }
    }
}
