namespace MovieCritters.Application.Movies
{
    public interface IMovieService
    {
        public Task<MovieResult> GetMovie(Guid id);
    }
}
