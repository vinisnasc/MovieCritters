using Microsoft.EntityFrameworkCore;
using MovieCritters.Domain.Entities;
using System.Reflection;

namespace MovieCritters.Infrastructure.Persistence
{
    public class MovieCrittersContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieCrittersContext(DbContextOptions<MovieCrittersContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRESQL"))
            .UseSnakeCaseNamingConvention();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                                  .Where(type => !string.IsNullOrEmpty(type.Namespace))
                                  .Where(type => type.GetInterfaces().Any(i => i.IsGenericType
                                  && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
