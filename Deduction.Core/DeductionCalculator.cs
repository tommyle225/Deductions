using System.Linq;

namespace Deduction.Core
{
    public static class DeductionCalculator
    {
        private static EmployeeDeductionCalculator _employeeDeductionCalculator = new EmployeeDeductionCalculator();
        private static DependentDeductionCalculator _dependentDeductionCalculator = new DependentDeductionCalculator();

        public static decimal CalculateDeductionCost(Employee employee)
        {
            decimal totalCost = _employeeDeductionCalculator.CalculateDeduction(employee.FirstName);

            if (employee.Dependents != null && employee.Dependents.Any())
            {
                employee.Dependents.Select(x => x.FirstName).ToList().ForEach(x =>
                {
                    totalCost = totalCost + _dependentDeductionCalculator.CalculateDeduction(x);
                });
            }
            return totalCost;
        }

        public static decimal Compute(decimal salary, decimal cost)
        {
            return salary - cost;
        }
    }
}
