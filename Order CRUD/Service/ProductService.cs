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

        public async Task<ProductResponseDTO> GetProduct(int id)
        {
            var product = await _productRepository.GetProduct(id);
            var productResponseDTO = new ProductResponseDTO();
            productResponseDTO.Id = product.Id;
            productResponseDTO.Name = product.Name;
            productResponseDTO.Price = product.Price;
            productResponseDTO.Description = product.Description;
            productResponseDTO.Category = product.Category;
            productResponseDTO.CreatedAt = product.CreatedAt;
            return productResponseDTO;
        }

        public async Task<ProductResponseDTO> UpdateProduct(int id, ProductRequestDTO productRequestDTO)
        {
            var product = await _productRepository.GetProduct(id);
            if (product == null)
            {
                throw new Exception("Customer Not Found");
            }

            product.Name = productRequestDTO.Name;
            product.Price = productRequestDTO.Price;
            product.Description = productRequestDTO.Description;
            product.Category = productRequestDTO.Category;

            var newcus = await _productRepository.UpdateProduct(product);
            var productResponseDTO = new ProductResponseDTO();
            productResponseDTO.Name = newcus.Name;
            productResponseDTO.Price = newcus.Price;
            productResponseDTO.Description = newcus.Description;
            productResponseDTO.Category = newcus.Category;
            return productResponseDTO;
        }
        public async Task<string> DeleteProduct(int id)
        {
            var delProduct = await _productRepository.GetProduct(id);
            if (delProduct == null)
            {
                throw new Exception("Product Not Found");
            }
            var result = await _productRepository.DeleteProduct(delProduct);
            return result;
        }
    }
}
