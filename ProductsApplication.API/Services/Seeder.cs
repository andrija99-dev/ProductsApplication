using Microsoft.EntityFrameworkCore;
using ProductsApplication.API.Services.Interfaces;
using ProductsApplication.Models.Context;
using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Services
{
    public class Seeder : ISeeder
    {
        private readonly ProductsAppDbContext _context;

        public Seeder(ProductsAppDbContext context)
        {
            _context = context;
        }
        public async Task Seed()
        {
            if (_context.Database.GetPendingMigrations().Any())
            {
                await _context.Database.MigrateAsync();
            }
            if (await _context.Database.CanConnectAsync())
            {
                if (!_context.Categories.Any())
                {
                    var categories = GetCategories().ToList();
                    _context.Categories.AddRange(categories);
                    await _context.SaveChangesAsync();

                    if (!_context.Products.Any())
                    {
                        var products = GetProducts(categories);
                        _context.Products.AddRange(products);
                        await _context.SaveChangesAsync();

                    }
                }

                
            }
        }

        private IEnumerable<Product> GetProducts(IEnumerable<Category> categories)
        {
            var product = new Product {
                
                ProductName = "Seed Test Product",
                Price = 1999.99M,
                Description = "This is a test product, made in seeding process",
                StockQuantity = 10,
                CreatedAt = DateTime.Now,
                ProductCategories = new List<ProductCategory>
                {
                    new ProductCategory{Category = categories.ElementAt(1)},
                    new ProductCategory{Category = categories.ElementAt(2)}
                }                

            };

            return new List<Product> { product };
        }

        private IEnumerable<Category> GetCategories()
        {
            List<Category> categories = new List<Category> {
                new(){
                    CategoryName = "Category One",
                    CreatedAt = DateTime.Now,

                },

                new(){
                    CategoryName = "Category Two",
                    CreatedAt = DateTime.Now,

                },

                new(){
                    CategoryName = "Category Three",
                    CreatedAt = DateTime.Now,

                }

            };

            return categories;
        }
    }
}
