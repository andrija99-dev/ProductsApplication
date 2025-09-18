using Microsoft.EntityFrameworkCore;
using ProductsApplication.API.Repositories.Interfaces;
using ProductsApplication.Models.Context;
using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ProductsAppDbContext _context;

        public ProductRepository(ProductsAppDbContext context)
        {
            _context = context;
        }

        public Product Add(Product product, List<int> categoryIds)
        {
            product.CreatedAt = DateTime.Now;
            foreach(var categoryId in categoryIds)
            {
                product.ProductCategories.Add(new ProductCategory
                {
                    CategoryId = categoryId
                });
            }

            _context.Products.Add(product);
            return product;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products
                .Include(p => p.ProductCategories)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if(product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            return true;
        }

        public async Task<IEnumerable<Product>> GetAllAsync(string? name) 
        {
            var query = _context.Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                var lowered = name.ToLower();
                query = query.Where(p => p.ProductName.ToLower().Contains(lowered));
            }

            return await query.ToListAsync();

        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<Product?> GetByNameAsync(string name)
        {
            return await _context.Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync(p => p.ProductName == name);
        }

        public Product Update(Product product, List<int> categoryIds)
        {
            product.ProductCategories.Clear();
            foreach (var categoryId in categoryIds)
            {
                product.ProductCategories.Add(new ProductCategory
                {
                    CategoryId = categoryId
                });
            }

            _context.Products.Update(product);
            return product;
        }
    }
}
