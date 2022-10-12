using Microsoft.Extensions.DependencyInjection;
using MovieCritters.Application.Common.Interfaces.Persistence;
using MovieCritters.Infrastructure.Persistence;

namespace MovieCritters.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            return services;
        }
    }
}
