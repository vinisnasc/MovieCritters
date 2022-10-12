using MovieCritters.Domain.Entities;

namespace MovieCritters.Application.Common.Interfaces.Persistence
{
    public interface IMovieRepository
    {
        public Task<Movie?> GetById(Guid id);
    }
}
