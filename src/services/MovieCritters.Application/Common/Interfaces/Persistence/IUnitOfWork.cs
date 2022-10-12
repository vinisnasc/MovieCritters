namespace MovieCritters.Application.Common.Interfaces.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }
        Task<bool> CommitAsync();
    }
}
