using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Movie.Enum;
using Movie.Payment;
using Movie.Subscription;

namespace Movie.User
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime JoinedDate { get; set; }
        private ICollection<Payment.Payment> Payments { get; set; }
        private ICollection<OwnedMovies> Movies { get; set; }
        private Subscription.Subscription? Subscription { get; set; }

        private bool IsSubscribed => Subscription is not null;

        
        public User(string name, int age)
        {
            this.UserId = Guid.NewGuid();
            this.Name = name;
            this.Age = age;
            this.JoinedDate = DateTime.Now;

            this.Payments = new List<Payment.Payment>();
            this.Movies = new List<OwnedMovies>();
        }



        public OperationResult Subscribe(SubscriptionType subscriptionType)
        {
            var subscription = SubscriptionFactory.CreateSubscription(subscriptionType);
            
            if (!IsSubscribed)
            {
                this.Subscription = subscription;
            }

            else
            {
                this.Subscription.SubscriptionCredit += subscription.SubscriptionCredit;
                this.Subscription.RemainCredit += subscription.SubscriptionCredit;
            }

            Payment.Payment payment = new SubscriptionPayment(subscription.SubscriptionCredit);
            this.Payments.Add(payment);

            return new(true, "Subscription Success");
        }


        public OperationResult RentMovie(int movieId)
        {
            if (!IsSubscribed)
                return new(false, "Only Subscribed Users Can Rent Movies.");

            var movie = new MovieDataSource().GetMovieById(movieId);

            if (!movie.IsRentable)
                return new(false, "Movie is not Rentable.");

            if (this.Movies.Any(x => x.Movie.MovieId.Equals(movieId)))
                return new(false, "User Owned This Movie Already.");
            
            if (this.Subscription.RemainCredit < movie.RentPrice)
                return new(false, "User Has Not Enough Credit.");

            this.Subscription.RemainCredit -= movie.RentPrice.Value;
            this.Movies.Add(new(movie, true));

            var rentPayment = new RentPayment(movie.RentPrice.Value);
            this.Payments.Add(rentPayment);

            return new(true, "Movie Rented.");
        }


        public OperationResult BuyMovie(int movieId)
        {
            if (this.Movies.Any(x => x.Movie.MovieId.Equals(movieId)))
                return new(false, "User Owned This Movie Already.");
            
            var movie = new MovieDataSource().GetMovieById(movieId);
            this.Movies.Add(new(movie, false));
            
            var rentPayment = new BuyPayment(movie.Price);
            this.Payments.Add(rentPayment);

            return new(true, "Movie Owned.");
        }
    }
}