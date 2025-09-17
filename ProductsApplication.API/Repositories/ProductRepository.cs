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

        public async Task<Product> AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return false;
            }
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() 
        {
            return await _context.Products.Include(p => p.ProductCategories).ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.Include(p => p.ProductCategories).FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
