using System.ComponentModel.DataAnnotations;

namespace ProductsApplication.API.DTOs;

public class CreateProductDto
{
    [Required]
    public string ProductName { get; set; } = default!;
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price invalid")]

    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int StockQuantity { get; set; }
    public List<int> CategoryIds { get; set; } = new List<int>();
}
