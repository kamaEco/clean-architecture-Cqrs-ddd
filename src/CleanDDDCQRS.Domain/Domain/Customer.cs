namespace CleanDDDCQRS.Domain
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public Customer(string firstName, string lastName, DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
