using System.Text.RegularExpressions;

namespace Deduction.Core
{
    public class DiscountHelper
    {
        public static decimal ApplyDiscount(decimal cost)
        {
            return decimal.Multiply(cost, .10M);
        }

        public static bool CanApplyNameDiscount(string name)
        {
            return !string.IsNullOrEmpty(name) && Regex.IsMatch(name, "^[Aa][A-Za-z]*$");
        }

    }
}
