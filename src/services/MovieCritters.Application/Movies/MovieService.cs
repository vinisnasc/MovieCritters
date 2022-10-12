using Mapster;
using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Application.Common.Results;

namespace MovieCritters.Application.Movies
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<MovieResult> GetMovie(Guid id)
        {
            var movie = await _movieRepository.GetById(id);

            if (movie is null)
            {
                throw new Exception("The movie with given id does not exist.");
            }

            return movie.Adapt<MovieResult>();
        }

        public PagedResult<MovieListResult> GetMovies(int pageNumber, int pageSize)
        {
            var movies = _movieRepository.GetPaged(pageNumber, pageSize, out int count);

            return new PagedResult<MovieListResult>()
            {
                Data = movies.Adapt<IList<MovieListResult>>(),
                Count = count
            };
        }
    }
}