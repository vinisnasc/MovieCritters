using Microsoft.Extensions.DependencyInjection;
using MovieCritters.Application.Movies;

namespace MovieCritters.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            return services;
        }
    }
}
