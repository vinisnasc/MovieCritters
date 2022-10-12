using MovieCritters.MVC.Services.Interfaces;

namespace MovieCritters.MVC.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/movie";

        public MovieService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
    }
}