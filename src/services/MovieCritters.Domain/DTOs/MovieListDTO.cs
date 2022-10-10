namespace MovieCritters.Domain.DTOs
{
    public class MovieListDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsAdult { get; set; }
        public DateOnly StartYear { get; set; }
        public DateOnly EndYear { get; set; }
        public List<string> Genres { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}
