using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieCritters.Domain.Entities;

namespace MovieCritters.Infrastructure.Persistence.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("movies");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.ImdbId).IsUnique();
            builder.Property(x => x.ImdbId).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired().HasColumnType("varchar");
            builder.Property(x => x.OriginalTitle).HasMaxLength(100).IsRequired().HasColumnType("varchar");
            builder.Property(x => x.Type).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.IsAdult).IsRequired().HasColumnType("boolean");
            builder.Property(x => x.StartYear).IsRequired().HasColumnType("int");
            builder.Property(x => x.EndYear).HasColumnType("int");
            builder.Property(x => x.RuntimeMinutes).IsRequired().HasColumnType("int");
            builder.Property(x => x.Genres).HasColumnType("text[]");
            builder.Property(x => x.Rating).IsRequired().HasColumnType("real");
            builder.Property(x => x.ImageUrl).HasMaxLength(255).HasColumnType("varchar");

            // Seed
            var movies = new List<Movie> {
                new Movie()
                {
                    Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f62"),
                    ImdbId = "tt0073486",
                    Type = "movie",
                    Title = "One Flew Over the Cuckoo's Nest",
                    OriginalTitle = "One Flew Over the Cuckoo's Nest",
                    IsAdult = false,
                    StartYear = 1975,
                    EndYear = null,
                    RuntimeMinutes = 133,
                    Genres = new[] { "Drama" },
                    Rating = 4.7,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/26/One_Flew_Over_the_Cuckoo%27s_Nest_poster.jpg"                    
                },
                new Movie()
                {
                    Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f63"),
                    ImdbId = "tt0328880",
                    Type = "movie",
                    Title = "Brother Bear",
                    OriginalTitle = "Brother Bear",
                    IsAdult = false,
                    StartYear = 2003,
                    EndYear = null,
                    RuntimeMinutes = 85,
                    Genres = new[] { "Adventure","Animation","Comedy" },
                    Rating = 4.5,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/86/Brother_Bear_Poster.png"
                },
                new Movie()
                {
                    Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f64"),
                    ImdbId = "tt0316654",
                    Type = "movie",
                    Title = "Spider-Man 2",
                    OriginalTitle = "Spider-Man 2",
                    IsAdult = false,
                    StartYear = 2004,
                    EndYear = null,
                    RuntimeMinutes = 127,
                    Genres = new[] { "Action","Adventure","Sci-Fi" },
                    Rating = 4.1,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/02/Spider-Man_2_Poster.jpg"
                },
                new Movie()
                {
                    Id = Guid.Parse("99a90b80-db93-4f76-a012-cbdadc878f65"),
                    ImdbId = "tt0172495",
                    Type = "movie",
                    Title = "Gladiator",
                    OriginalTitle = "Gladiator",
                    IsAdult = false,
                    StartYear = 2000,
                    EndYear = null,
                    RuntimeMinutes = 155,
                    Genres = new[] { "Action","Adventure","Drama" },
                    Rating = 4.8,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fb/Gladiator_%282000_film_poster%29.png"
                }
            };
            builder.HasData(movies);
        }
    }
}
