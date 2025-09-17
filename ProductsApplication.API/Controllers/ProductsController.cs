using Microsoft.AspNetCore.Mvc;
using ProductsApplication.API.DTOs;
using ProductsApplication.API.Services.Interfaces;
using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetById(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductDto dto)
        {
            var created = await _productService.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.ProductId }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute]int id, [FromBody] CreateProductDto dto)
        {
            var updated = await _productService.Update(id, dto);            
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return NoContent();
        }
    }
}
