using MovieCritters.Domain.Entities;

namespace MovieCritters.Application.Common.Interfaces.Persistence
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        public Task<T> GetByIdAsync(Guid id);
    }
}
