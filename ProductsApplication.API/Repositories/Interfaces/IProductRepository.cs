using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> AddAsync(Product product, List<int> categoryIds);
        Task<Product> UpdateAsync(Product product, List<int> categoryIds);
        Task<bool> DeleteAsync(int id);
        Task<Product?> GetByNameAsync(string name);
    }
}
