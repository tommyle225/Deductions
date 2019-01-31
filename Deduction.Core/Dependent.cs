namespace Deduction.Core
{
    public class Dependent : Person
    {
        public DependentType DependentType { get; private set; }

        public Dependent(DependentType dependentType, string firstName, string lastName) : base(firstName, lastName)
        {
            DependentType = dependentType;
        }
    }
}