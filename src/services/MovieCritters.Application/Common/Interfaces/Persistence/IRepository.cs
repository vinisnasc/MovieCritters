using MovieCritters.Domain.Entities;

namespace MovieCritters.Application.Common.Interfaces.Persistence
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IList<T> GetPaged(int page, int pageSize, out int count);
    }
}
