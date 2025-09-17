namespace ProductsApplication.API.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<bool> CategoriesExistAsync(IEnumerable<int> categoryIds);
    }
}
