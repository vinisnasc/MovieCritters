using MovieCritters.Application.Common.Results;

namespace MovieCritters.Application.Movies
{
    public interface IMovieService
    {
        public Task<MovieResult> GetMovie(Guid id);
        public PagedResult<MovieListResult> GetMovies(int pageNumber, int pageSize);
    }
}
