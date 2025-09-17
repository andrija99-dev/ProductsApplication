using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductsApplication.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApplication.Models.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddDatabaseModels(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ProductsApplicationDb");
        services.AddDbContext<ProductsAppDbContext>(options => options.UseSqlServer(connectionString));
    }
}
