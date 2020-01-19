using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.Entities.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName, 3, "FirstName", "Invalid FirstName, with min characters")
            .HasMaxLen(FirstName, 40, "FirstName", "Invalid FirstName, with max characters"));

            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(LastName, 3, "LastName", "Invalid LastName, with min characters")
            .HasMaxLen(LastName, 40, "LastName", "Invalid LastName, with max characters"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}

