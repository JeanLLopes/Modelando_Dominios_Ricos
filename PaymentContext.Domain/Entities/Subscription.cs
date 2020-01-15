using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Active { get; set; }
        public List<Payment> MyProperty { get; set; }
    }
}