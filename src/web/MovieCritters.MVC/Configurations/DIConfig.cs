using MovieCritters.MVC.Services;
using MovieCritters.MVC.Services.Interfaces;

namespace MovieCritters.MVC.Configurations
{
    public static class DIConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IMovieService, MovieService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddHttpClient<IMovieService, MovieService>(c =>
                                    c.BaseAddress = new Uri(configuration["ServiceUrls:MovieCrittersApi"]));
        }
    }
}