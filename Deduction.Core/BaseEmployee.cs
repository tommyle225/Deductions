using System.Collections.Generic;

namespace Deduction.Core
{
    public abstract class BaseEmployee : Person
    {
        protected decimal Salary { get => 2000.00M * 26; }
                
        protected BaseEmployee(string firstName, string lastName) : base(firstName, lastName)
        {
           
        }

        public abstract decimal GetSalary();

        public void AddDependent(IPerson dependent)
        {
            Dependents.Add(dependent);
        }

        public void RemoveDependent(IPerson dependent)
        {
            Dependents.Remove(dependent);
        }

       

        public List<IPerson> Dependents { get; set; } = new List<IPerson>();

    }
}