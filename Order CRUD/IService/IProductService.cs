using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;

namespace Order_CRUD.IService
{
    public interface IProductService
    {
        Task<ProductResponseDTO> AddProduct(ProductRequestDTO productRequestDTO);
        Task<ProductResponseDTO> GetProduct(int id);
        Task<ProductResponseDTO> UpdateProduct(int id, ProductRequestDTO productRequestDTO);
        Task<string> DeleteProduct(int id);
    }
}
