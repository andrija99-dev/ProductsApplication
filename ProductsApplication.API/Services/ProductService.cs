using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using ProductsApplication.API.DTOs;
using ProductsApplication.API.Exceptions;
using ProductsApplication.API.Repositories.Interfaces;
using ProductsApplication.API.Services.Interfaces;
using ProductsApplication.Models.Entities;

namespace ProductsApplication.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository repository, ICategoryRepository categoryRepository, 
            IMapper mapper, ILogger<ProductService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public async Task<ProductDto> Create(CreateProductDto dto)
        {
            _logger.LogInformation("Creating new Product: {ProductName}", dto.ProductName);

            var existingProduct = await _repository.GetByNameAsync(dto.ProductName);
            if(existingProduct != null)
            {
                _logger.LogWarning("Product with name: {ProductName} already exists", dto.ProductName);
                throw new AlreadyExistsException(nameof(Product), dto.ProductName);
            }

            var categoriesValid = await _categoryRepository.CategoriesExistAsync(dto.CategoryIds);
            if (!categoriesValid)
            {
                _logger.LogWarning("One or more categories for Product: {ProductName}, does not exist", dto.ProductName);
                throw new NotFoundException(nameof(Category));
            }

            var product = _mapper.Map<Product>(dto);
            var created = await _repository.AddAsync(product, dto.CategoryIds);

            _logger.LogInformation("Product {ProductName} succesfully created, with ID: {ProductId}", product.ProductName, product.ProductId);
            var createdWithCategories = await _repository.GetByIdAsync(created.ProductId);
            return _mapper.Map<ProductDto>(createdWithCategories);
        }

        public async Task Delete(int id)
        {
            _logger.LogInformation("Deleting Product with ID: {ProductId}", id);
            var deleted =  await _repository.DeleteAsync(id);
            if (!deleted)
            {
                _logger.LogWarning("Product with ID: {ProductId} does not exist", id);

                throw new NotFoundException(nameof(Product));
            }

            _logger.LogInformation("Product with ID: {ProductId} succesfully deleted", id);

        }

        public async Task<IEnumerable<ProductDto>> GetAll(string? name)
        {
            _logger.LogInformation("Fetching all Products, with filter: {Filter}", name);

            var products = await _repository.GetAllAsync(name);
            _logger.LogInformation("{ProductCount} Products retrieved from database", products.Count());

            return products.Select(p => _mapper.Map<ProductDto>(p));
        }

        public async Task<ProductDto> GetById(int id)
        {
            _logger.LogInformation("Fetching Product with ID: {ProductId}", id);

            var product = await _repository.GetByIdAsync(id);
            if(product == null)
            {
                _logger.LogWarning("Product with ID: {ProductId} does not exist", id);

                throw new NotFoundException(nameof(Product));
            }

            _logger.LogInformation("Product with ID: {ProductId} retrieved succesfully", id);

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> Update(int id, CreateProductDto dto)
        {
            _logger.LogInformation("Updating Product with ID: {ProductId}", id);

            var existing = await _repository.GetByIdAsync(id);
            if(existing == null)
            {
                _logger.LogWarning("Product with ID: {ProductId} does not exist", id);

                throw new NotFoundException(nameof(Product));
            }

            var productWithSameName = await _repository.GetByNameAsync(dto.ProductName);
            if(productWithSameName != null && productWithSameName.ProductId != id)
            {
                _logger.LogWarning("Another Product with name: {ProductName} already exists", dto.ProductName);
                throw new AlreadyExistsException(nameof(Product), dto.ProductName);
            }

            var categoriesValid = await _categoryRepository.CategoriesExistAsync(dto.CategoryIds);
            if (!categoriesValid)
            {
                _logger.LogWarning("One or more categories for ProductId: {ProductId}, does not exist", id);

                throw new NotFoundException(nameof(Category));
            }

            _mapper.Map(dto, existing);

            var updated = await _repository.UpdateAsync(existing, dto.CategoryIds);

            _logger.LogInformation("Product with ID: {ProductId} succesfully updated", id);
            var updatedWithCategories = await _repository.GetByIdAsync(existing.ProductId);

            return _mapper.Map<ProductDto>(updatedWithCategories);
        }
    }
}
