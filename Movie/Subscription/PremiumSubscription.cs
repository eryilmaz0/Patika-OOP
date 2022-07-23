using System;

namespace Movie.Subscription
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(Guid id):base(id)
        {
            this.SubscriptionCredit = 10000;
            this.RemainCredit = 10000;
        }
    }
}