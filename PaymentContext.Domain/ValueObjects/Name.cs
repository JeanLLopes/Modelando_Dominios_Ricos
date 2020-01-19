using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.Entities.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FirstName))
            {
                AddNotification("Name", "Name invalid");
            }
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}

