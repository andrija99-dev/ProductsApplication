using ProductsApplication.API.Repositories;
using ProductsApplication.API.Repositories.Interfaces;
using ProductsApplication.API.Services;
using ProductsApplication.API.Services.Interfaces;

namespace ProductsApplication.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
