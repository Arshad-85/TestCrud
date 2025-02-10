using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;

namespace Order_CRUD.IService
{
    public interface IProductService
    {
        Task<ProductResponseDTO> AddProduct(ProductRequestDTO productRequestDTO);
    }
}
