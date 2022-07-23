using System;

namespace Movie.Subscription
{
    public abstract class Subscription
    {
        public Guid SubscriptionId { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public decimal SubscriptionCredit { get; set; }
        public decimal RemainCredit { get; set; }


        public Subscription(Guid id)
        {
            this.SubscriptionId = id;
            this.SubscriptionDate = DateTime.Now;;
        }
    }
}