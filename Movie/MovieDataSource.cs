using System.Collections.Generic;
using System.Linq;

namespace Movie
{
    public class MovieDataSource
    {
        private static List<Movie.Movie> _movies;

        static MovieDataSource()
        {
            _movies = new List<Movie.Movie>()
            {
                new()
                {
                    MovieId = 1,
                    Name = "Movie 1",
                    Category = "Category 1",
                    Description = "Movie 1 Description",
                    IsRentable = true,
                    Picture = "Movie1.png",
                    Price = 50.00M,
                    RentPrice = 14.99M
                },

                new()
                {
                    MovieId = 2,
                    Name = "Movie 2",
                    Category = "Category 2",
                    Description = "Movie 2 Description",
                    IsRentable = true,
                    Picture = "Movie2.png",
                    Price = 150.00M,
                    RentPrice = 24.99M
                },


                new()
                {
                    MovieId = 3,
                    Name = "Movie 3",
                    Category = "Category 3",
                    Description = "Movie 3 Description",
                    IsRentable = true,
                    Picture = "Movie3.png",
                    Price = 75.00M,
                    RentPrice = 39.99M
                },


                new()
                {
                    MovieId = 4,
                    Name = "Movie 4",
                    Category = "Category 4",
                    Description = "Movie 4 Description",
                    IsRentable = true,
                    Picture = "Movie4.png",
                    Price = 200.00M,
                    RentPrice = 99.99M
                }
            };
        }


        public List<Movie.Movie> ListAllMovies()
        {
            return _movies;
        }


        public List<Movie.Movie> ListOrderedMoviesByPrice()
        {
            return _movies.OrderBy(x => x.Price).ToList();
        }


        public Movie.Movie GetMovieById(int movieId)
        {
            return _movies.FirstOrDefault(x => x.MovieId.Equals(movieId));
        }


        public void DemandNewMovie(Movie.Movie movie)
        {
            _movies.Add(movie);
        }

    }
}