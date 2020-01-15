using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
    }

    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        public string Number { get; set; }
    }

    public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LasTransactionNumber { get; set; }
    }

    public class PayPalPayment : Payment
    {
        public string TransactionCode { get; set; }
    }
}