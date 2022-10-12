namespace MovieCritters.Application.Common.Results
{
    public class PagedResult<T> where T : class
    {
        public IList<T> Data { get; set; }
        public int Count { get; set; }
    }
}
