using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApplication.Models.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = default!;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int StockQuantity { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}
