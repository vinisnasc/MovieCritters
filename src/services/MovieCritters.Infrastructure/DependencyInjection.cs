using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Infrastructure.Persistence;

namespace MovieCritters.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Context
            services.AddDbContext<MovieCrittersContext>(
                options => options.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRESQL")));

            services.AddScoped<DbContext, MovieCrittersContext>();

            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
