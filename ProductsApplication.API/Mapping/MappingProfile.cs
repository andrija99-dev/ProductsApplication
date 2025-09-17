using AutoMapper;
using ProductsApplication.API.DTOs;
using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>()
        .ForMember(dest => dest.Categories, opt =>
        opt.MapFrom(src => src.ProductCategories != null
            ? src.ProductCategories
                .Where(pc => pc.Category != null)
                .Select(pc => pc.Category!.CategoryName)
                .ToList()
            : new List<string>()));

        CreateMap<CreateProductDto, Product>()
            .ForMember(dest => dest.ProductCategories, opt => opt.Ignore());


    }
}
