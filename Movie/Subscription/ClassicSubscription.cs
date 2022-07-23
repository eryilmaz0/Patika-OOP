using System;

namespace Movie.Subscription
{
    public class ClassicSubscription : Subscription
    {
        public ClassicSubscription(Guid id):base(id)
        {
            this.SubscriptionCredit = 1000;
            this.RemainCredit = 1000;
        }
    }
}