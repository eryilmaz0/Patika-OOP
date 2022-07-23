namespace Movie.Movie
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public bool IsRentable { get; set; }
        public decimal? RentPrice { get; set; }
    }
}