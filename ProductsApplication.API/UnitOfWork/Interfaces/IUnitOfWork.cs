using ProductsApplication.API.Repositories.Interfaces;

namespace ProductsApplication.API.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task<int> SaveChangesAsync();
    }
}
