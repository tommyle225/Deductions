using System;

namespace Deduction.Core
{
    public class Employee : BaseEmployee
    {
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AddDependent(IPerson dependent, DependentType dependentType)
        {
            Dependents.Add(new Dependent(dependentType, dependent.FirstName, dependent.LastName));
        }

        public override decimal GetSalary()
        {
            return Salary;
        }

    }
}