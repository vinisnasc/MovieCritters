using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Domain.Entities;

namespace MovieCritters.Infrastructure.Persistence
{
    public class MovieRepository : IMovieRepository
    {
        private static readonly List<Movie> _movies = new List<Movie>() 
        {
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
                Genres = new() { "Drama" },
                Rating = 4.7
            },
            new Movie()
            {
                Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f63"),
                ImdbId = "tt0211464",
                Type = "movie",
                Title = "Kingpin 2",
                OriginalTitle = "Kingpin",
                IsAdult = false,
                StartYear = 1985,
                EndYear = null,
                RuntimeMinutes = 87,
                Genres = new() { "Drama" },
                Rating = 3.2
            },
            new Movie()
            {
                Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f64"),
                ImdbId = "tt0211464",
                Type = "movie",
                Title = "Kingpin 3",
                OriginalTitle = "Kingpin",
                IsAdult = false,
                StartYear = 1985,
                EndYear = null,
                RuntimeMinutes = 87,
                Genres = new() { "Drama" },
                Rating = 4.1
            },
            new Movie()
            {
                Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f65"),
                ImdbId = "tt0211464",
                Type = "movie",
                Title = "Kingpin 4",
                OriginalTitle = "Kingpin",
                IsAdult = false,
                StartYear = 1985,
                EndYear = null,
                RuntimeMinutes = 87,
                Genres = new() { "Drama" },
                Rating = 2.1
            }
        };

        public async Task<Movie?> GetById(Guid id)
        {
            return _movies.SingleOrDefault(x => x.Id == id);
        }

        public IList<Movie> GetPaged(int page, int pageSize, out int count)
        {
            count = 0;

            if (page < 0)
                page = 0;
                
            var skip = page * pageSize;

            if (pageSize <= 0)
                pageSize = 1;

            count = _movies.Count;

            return _movies.Skip(skip).Take(pageSize).ToList();
        }
    }
}