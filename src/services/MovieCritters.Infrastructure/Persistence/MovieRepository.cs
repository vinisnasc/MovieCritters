using Microsoft.EntityFrameworkCore;
using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Domain.Entities;

namespace MovieCritters.Infrastructure.Persistence
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}