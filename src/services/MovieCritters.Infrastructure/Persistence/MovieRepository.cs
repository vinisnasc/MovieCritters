using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Domain.Entities;

namespace MovieCritters.Infrastructure.Persistence
{
    public class MovieRepository : IMovieRepository
    {
        private static readonly List<Movie> _movies = new List<Movie>() {
            new Movie()
            {
                Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f62"),
                ImdbId = "tt0211464",
                Type = "movie",
                Title = "Kingpin",
                OriginalTitle = "Kingpin",
                IsAdult = false,
                StartYear = 1985,
                EndYear = null,
                RuntimeMinutes = 87,
                Genres = new() { "Drama" }
            }
        };

        public async Task<Movie?> GetById(Guid id)
        {
            return _movies.SingleOrDefault(x => x.Id == id);
        }
    }
}