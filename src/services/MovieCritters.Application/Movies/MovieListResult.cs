namespace MovieCritters.Application.Movies
{
    public record MovieListResult(
        Guid Id,
        string Title,
        bool IsAdult,
        int StartYear,
        int? EndYear,
        List<string> Genres,
        double Rating,
        string ImageUrl);
}
