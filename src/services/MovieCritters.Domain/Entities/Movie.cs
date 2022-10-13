namespace MovieCritters.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Type { get; set; }
        public bool IsAdult { get; set; }
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
        public int RuntimeMinutes { get; set; }
        public string[] Genres { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}