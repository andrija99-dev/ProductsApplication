using ProductsApplication.API.Repositories.Interfaces;
using ProductsApplication.API.UnitOfWork.Interfaces;
using ProductsApplication.Models.Context;

namespace ProductsApplication.API.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductsAppDbContext _context;
        public IProductRepository Products {  get; }
        public ICategoryRepository Categories {  get; }

        public UnitOfWork(IProductRepository productRepository,ProductsAppDbContext context,
            ICategoryRepository categoryRepository)
        {
            _context = context;
            Products = productRepository;
            Categories = categoryRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
