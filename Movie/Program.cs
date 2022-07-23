using System;
using Movie.Enum;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListMovies();
            // ListOrderedMoviesByPrice();
            User.User user = new("Eren Yilmaz", 24);
            user.Subscribe(SubscriptionType.Premium);
            user.Subscribe(SubscriptionType.Premium);
            user.BuyMovie(1);
            user.BuyMovie(2);
            user.RentMovie(3);
            user.RentMovie(4);
        }

        private static void ListMovies()
        {
            var movies = new MovieDataSource().ListAllMovies();
            
            movies.ForEach(movie =>
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Movie Id : {movie.MovieId}");
                Console.WriteLine($"Movie Name : {movie.Name}");
                Console.WriteLine($"Movie Description : {movie.Description}");
                Console.WriteLine(movie.IsRentable ? "Rentable" : "Not Rentable");
                Console.WriteLine($"Movie Picture : {movie.Picture}");
                Console.WriteLine($"Movie Price : {movie.Price}");
                Console.WriteLine(movie.IsRentable ? $"Rent Price : {movie.RentPrice}" : "Rent Price : -");
                Console.WriteLine("-----------------------------");
            });
        }


        private static void ListOrderedMoviesByPrice()
        {
            var movies = new MovieDataSource().ListOrderedMoviesByPrice();
            
            movies.ForEach(movie =>
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Movie Id : {movie.MovieId}");
                Console.WriteLine($"Movie Name : {movie.Name}");
                Console.WriteLine($"Movie Description : {movie.Description}");
                Console.WriteLine(movie.IsRentable ? "Rentable" : "Not Rentable");
                Console.WriteLine($"Movie Picture : {movie.Picture}");
                Console.WriteLine($"Movie Price : {movie.Price}");
                Console.WriteLine(movie.IsRentable ? $"Rent Price : {movie.RentPrice}" : "Rent Price : -");
                Console.WriteLine("-----------------------------");
            });
        }
    }
}