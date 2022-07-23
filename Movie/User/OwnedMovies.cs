using System;

namespace Movie.User
{
    public class OwnedMovies
    {
        public Movie.Movie Movie { get; set; }
        public bool IsRented { get; set; }
        public DateTime OwnedDate { get; set; }


        public OwnedMovies(Movie.Movie movie, bool isRented)
        {
            this.Movie = movie;
            this.IsRented = isRented;
            this.OwnedDate = DateTime.Now;
        }
    }
}