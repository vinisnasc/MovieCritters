namespace MovieCritters.Application.Movies
{
    public record MovieResult(
        Guid Id,
        string ImdbId,
        string Title,
        string OriginalTitle,
        string Type,
        bool IsAdult,
        int StartYear,
        int? EndYear,
        int RuntimeMinutes,
        List<string> Genres,
        double Rating,
        string ImageUrl);
}
