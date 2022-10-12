using Microsoft.EntityFrameworkCore;
using MovieCritters.Application.Common.Interfaces.Persistence;

namespace MovieCritters.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public IMovieRepository MovieRepository { get; set; }

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;

            MovieRepository = new MovieRepository(_dbContext);
        }

        public async Task<bool> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
