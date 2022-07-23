using System;

namespace Movie.Subscription
{
    public class GoldSubscription : Subscription
    {
        public GoldSubscription(Guid id):base(id)
        {
            this.SubscriptionCredit = 5000;
            this.RemainCredit = 5000;
        }
    }
}