using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync(string? name);
        Task<Product?> GetByIdAsync(int id);
        Product Add(Product product, List<int> categoryIds);
        Product Update(Product product, List<int> categoryIds);
        Task<bool> DeleteAsync(int id);
        Task<Product?> GetByNameAsync(string name);
    }
}
