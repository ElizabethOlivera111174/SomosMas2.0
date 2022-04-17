namespace Project.Domain.Helpers.Pagination
{
    public interface IUriService
    {
        public string GetPage(string route, int? page);
    }
}