using ProductsApplication.API.Repositories.Interfaces;
using ProductsApplication.API.Services.Interfaces;
using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Create(Product product)
        {
            var created = await _repository.AddAsync(product);
            return created;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Product?> Update(int id, Product product)
        {
            var existing = await _repository.GetByIdAsync(id);
            if(existing == null)
            {
                return null;
            }
            existing.ProductName = product.ProductName;
            existing.Price = product.Price;
            existing.Description = product.Description;
            existing.StockQuantity = product.StockQuantity;

            var updated = await _repository.UpdateAsync(existing);
            return updated;
        }
    }
}
