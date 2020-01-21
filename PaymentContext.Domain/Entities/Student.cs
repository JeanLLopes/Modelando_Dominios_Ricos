using System;
using System.Collections.Generic;
using Flunt.Validations;
using PaymentContext.Domain.Entities.ValueObjects;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private List<Subscription> _subscriptions;


        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();


            AddNotifications(name, document, email);
        }

        public string FirstName { get; private set; }

        public void AddSubscription(object subscription)
        {
            throw new NotImplementedException();
        }

        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }


        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;

            foreach (var sub in Subscriptions)
            {
                if (sub.Active)
                {
                    hasSubscriptionActive = true;
                }
            }
            AddNotifications(new Contract()
            .Requires()
            .IsFalse(hasSubscriptionActive, "Subscriptions", "not has active subscription")
            .AreEquals(0, subscription.Payments.Count, "Subscription.Payments", "Student not has payments"));
        }
    }
}
