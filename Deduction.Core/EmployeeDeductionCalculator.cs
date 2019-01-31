namespace Deduction.Core
{
    public class EmployeeDeductionCalculator : DeductionCalculatorBase
    {
        public override decimal CalculateDeduction(string name)
        {
            return DiscountHelper.CanApplyNameDiscount(name) ? DiscountHelper.ApplyDiscount(1000.00M) : 1000.00M;
        }
    }
}
