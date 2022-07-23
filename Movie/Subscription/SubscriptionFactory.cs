using System;
using Movie.Enum;

namespace Movie.Subscription
{
    public class SubscriptionFactory
    {
        public static Subscription CreateSubscription(SubscriptionType type)
        {
            return type switch
            {
                SubscriptionType.Classic => new ClassicSubscription(Guid.NewGuid()),
                SubscriptionType.Gold => new GoldSubscription(Guid.NewGuid()),
                SubscriptionType.Premium => new PremiumSubscription(Guid.NewGuid())
            };
        }
    }
}