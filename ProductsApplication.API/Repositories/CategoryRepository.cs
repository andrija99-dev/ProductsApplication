using Microsoft.EntityFrameworkCore;
using ProductsApplication.API.Repositories.Interfaces;
using ProductsApplication.Models.Context;

namespace ProductsApplication.API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly ProductsAppDbContext _dbContext;
        public CategoryRepository(ProductsAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CategoriesExistAsync(IEnumerable<int> categoryIds)
        {
            var count = await _dbContext.Categories.CountAsync(c => categoryIds.Contains(c.CategoryId));

            return count == categoryIds.Count();
        }
    }
}
