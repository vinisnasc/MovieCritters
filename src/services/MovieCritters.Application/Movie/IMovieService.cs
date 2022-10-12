namespace MovieCritters.Application.Movie
{
    public interface IMovieService
    {
        public Task<MovieResult> GetMovie(Guid id);
    }
}
