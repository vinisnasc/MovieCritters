using MovieCritters.Domain.Entities;

namespace MovieCritters.Application.Common.Interfaces.Persistence
{
    public interface IMovieRepository
    {
        public Task<Movie?> GetById(Guid id);
        public IList<Movie> GetPaged(int page, int pageSize, out int count);
    }
}
