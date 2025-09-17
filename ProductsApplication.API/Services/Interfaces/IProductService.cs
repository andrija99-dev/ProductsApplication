using ProductsApplication.API.DTOs;
using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> GetById(int id);
        Task<ProductDto> Create(CreateProductDto dto);
        Task<ProductDto> Update(int id, CreateProductDto dto);
        Task Delete(int id);
    }
}
