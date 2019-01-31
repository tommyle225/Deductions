namespace Deduction.Core
{
    public class Person : IPerson
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }


}