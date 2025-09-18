using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApplication.GUI.Model
{
    public class CreateProductDto
    {
        public string ProductName { get; set; } = default!;
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int StockQuantity { get; set; }
        public List<int> CategoryIds { get; set; } = new List<int>();
    }
}
