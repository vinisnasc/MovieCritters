using Microsoft.EntityFrameworkCore;
using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Domain.Entities;

namespace MovieCritters.Infrastructure.Persistence
{
    public class BaseRepository<T> : IRepository<T>, IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public IList<T> GetPaged(int page, int pageSize, out int count)
        {
            if (page < 0)
                page = 0;

            var skip = page * pageSize;

            if (pageSize <= 0)
                pageSize = 1;

            var query = _dbContext.Set<T>().AsQueryable().AsNoTracking();

            count = query.Count();

            return query.Skip(skip).Take(pageSize).ToList();
        }
    }
}
