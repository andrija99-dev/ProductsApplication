using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApplication.Models.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}
