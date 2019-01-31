using System;
using Deduction.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deductions.Tests
{
    [TestClass]
    public class DeductionsTests
    {
        decimal salary = 2000.00M;
        decimal employeeDeduction = 1000M;
        decimal dependentDeduction = 500M;

        [TestMethod]
        public void TestEmployeeDeduction()
        {
            var employee1 = new Employee("John", "Smith");
            var cost = DeductionCalculator.CalculateDeductionCost(employee1);
            Assert.IsTrue(cost == 1000.0M);


        }
        [TestMethod]
        public void TestEmployeeDeductionWithDiscount()
        {
            var employee1 = new Employee("Anna", "Jones");
            var cost1 = DeductionCalculator.CalculateDeductionCost(employee1);

            Assert.IsTrue(cost1 == (decimal.Multiply(employeeDeduction, .10M)));
        }

        [TestMethod]
        public void TestEmployeeDeductionWithDependents()
        {
            decimal cost;
            var employee1 = new Employee("Anna", "Jones");
            cost = DeductionCalculator.CalculateDeductionCost(employee1);
            Assert.IsTrue(employeeDeduction * .10M == cost);
            employee1.AddDependent(new Dependent(DependentType.Spouse, "John", "Doe"));

            DependentDeductionCalculator d = new DependentDeductionCalculator();
            cost = employeeDeduction * .10M + d.CalculateDeduction("John");

            Assert.IsTrue(cost == DeductionCalculator.CalculateDeductionCost(employee1));


        }

        [TestMethod]
        public void TestEmployeeDeductionWithMultipleDependents()
        {
            decimal cost;
            decimal cost1;
            decimal cost2;
            DependentDeductionCalculator d = new DependentDeductionCalculator();
            var employee1 = new Employee("Anna", "Jones");
            cost = DeductionCalculator.CalculateDeductionCost(employee1);
            Assert.IsTrue(employeeDeduction * .10M == cost);
            employee1.AddDependent(new Dependent(DependentType.Spouse, "Amy", "Doe"));
            cost1 =  d.CalculateDeduction("Amy");

            employee1.AddDependent(new Dependent(DependentType.Spouse, "Antoine", "Doe"));
            cost2 =  d.CalculateDeduction("Antoine");

            
            Assert.IsTrue((employeeDeduction * .10M) + (2* (dependentDeduction * .10M)) == DeductionCalculator.CalculateDeductionCost(employee1));


        }
    }
}
