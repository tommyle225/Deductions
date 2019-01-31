namespace Deduction.Core
{
    public class DependentDeductionCalculator : DeductionCalculatorBase
    {
        public override decimal CalculateDeduction(string name)
        {
            return DiscountHelper.CanApplyNameDiscount(name) ? DiscountHelper.ApplyDiscount(500.00M) : 500.00M;
        }
    }
}
