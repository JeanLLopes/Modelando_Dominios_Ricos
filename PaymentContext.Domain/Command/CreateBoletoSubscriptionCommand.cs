using System;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Entities.ValueObjects;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Comamnds;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string PayerDocument { get; set; }
        public Email PayerEmail { get; set; }
        public EDocumentType DocumentType { get; set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }

        //NOT GET TO YOUR DOMAIN INVALID INFORMATIONS RETURN BY DATABASE
        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName, 3, "FirstName", "Invalid FirstName, with min characters")
            .HasMaxLen(FirstName, 40, "FirstName", "Invalid FirstName, with max characters"));
        }
    }
}