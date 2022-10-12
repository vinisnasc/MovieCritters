using Mapster;
using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Application.Common.Results;

namespace MovieCritters.Application.Movies
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MovieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<MovieResult> GetMovie(Guid id)
        {
            var movie = await _unitOfWork.MovieRepository.GetByIdAsync(id);

            if (movie is null)
            {
                throw new Exception("The movie with given id does not exist.");
            }

            return movie.Adapt<MovieResult>();
        }

        public PagedResult<MovieListResult> GetMovies(int pageNumber, int pageSize)
        {
            var movies = _unitOfWork.MovieRepository.GetPaged(pageNumber, pageSize, out int count);

            return new PagedResult<MovieListResult>()
            {
                Data = movies.Adapt<IList<MovieListResult>>(),
                Count = count
            };
        }
    }
}