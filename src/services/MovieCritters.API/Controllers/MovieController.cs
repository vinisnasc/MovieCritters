using Microsoft.AspNetCore.Mvc;
using MovieCritters.Application.Common.Results;
using MovieCritters.Application.Movies;
using System.Net;

namespace MovieCritters.API.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : BaseApiController
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;

        public MovieController(ILogger<MovieController> logger,
            IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        /// <summary>
        /// Fetch a paginated list of movies.
        /// </summary>
        /// <param name="pageNumber">Page number starting from 0.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(PagedResult<MovieListResult>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)] 
        public IActionResult Get([FromQuery] int pageNumber, int pageSize)
        {
            try
            {
                return Ok(_movieService.GetMovies(pageNumber, pageSize));
            }
            catch (Exception ex)
            {
                var errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _logger.LogError(ex, errorMessage);
                return BadRequest($"Something went wrong when listing movies: {ex.Message}");
            }
        }

        /// <summary>
        /// Fetch a movie.
        /// </summary>
        /// <param name="id">Movie Id.</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MovieResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                return Ok(await _movieService.GetMovie(id));
            }
            catch (Exception ex)
            {
                var errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _logger.LogError(ex, errorMessage);
                return BadRequest($"Something went wrong when fetching the movie: {ex.Message}");
            }
        }
    }
}
