using System;

namespace Movie.Payment
{
    public abstract class Payment
    {
        public Guid PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }

        public Payment(decimal amount)
        {
            this.PaymentId = Guid.NewGuid();
            this.Amount = amount;
            this.PaymentDate = DateTime.Now;
        }
    }
}