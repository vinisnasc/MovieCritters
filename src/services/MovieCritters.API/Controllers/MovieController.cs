using Microsoft.AspNetCore.Mvc;
using MovieCritters.Domain.DTOs;
using System.Net;

namespace MovieCritters.API.Controllers
{
    [Route("[api/controller]")]
    public class MovieController : BaseApiController
    {
        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Fetch a paginated list of movies.
        /// </summary>
        /// <param name="pageNumber">Page number starting from 0.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromQuery] int pageNumber, int pageSize)
        {
            try
            {
                return BadRequest(new NotImplementedException());
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
        [ProducesResponseType(typeof(MovieDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                return BadRequest(new NotImplementedException());
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
