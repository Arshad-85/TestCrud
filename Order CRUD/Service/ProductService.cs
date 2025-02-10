using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;
using Order_CRUD.Entity;
using Order_CRUD.IRepository;
using Order_CRUD.IService;
using Order_CRUD.Repository;

namespace Order_CRUD.Service
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponseDTO> AddProduct(ProductRequestDTO productRequestDTO)
        {
            var product = new Product();
            product.Name = productRequestDTO.Name;
            product.Price = productRequestDTO.Price;
            product.Description = productRequestDTO.Description;
            product.Category = productRequestDTO.Category;
            product.Stock = productRequestDTO.Stock;
            product.CreatedAt = DateTime.Now;

            var newProduct = await _productRepository.AddProduct(product);
            var productResponseDTO = new ProductResponseDTO();
            productResponseDTO.Id = newProduct.Id;
            productResponseDTO.Name = newProduct.Name;
            productResponseDTO.Price = newProduct.Price;
            productResponseDTO.Description = newProduct.Description;
            productResponseDTO.Category = newProduct.Category;
            productResponseDTO.CreatedAt = newProduct.CreatedAt;
            return productResponseDTO;
        }
    }
}
