using ProductsApplication.API.Middleware;
using ProductsApplication.API.Repositories;
using ProductsApplication.API.Repositories.Interfaces;
using ProductsApplication.API.Services;
using ProductsApplication.API.Services.Interfaces;
using ProductsApplication.API.UnitOfWork.Interfaces;

namespace ProductsApplication.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISeeder, Seeder>();
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddAutoMapper(typeof(ServiceCollectionExtensions));
            services.AddScoped<ErrorHandlingMiddleware>();

        }
    }
}
