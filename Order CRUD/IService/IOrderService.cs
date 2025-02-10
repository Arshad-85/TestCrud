using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;

namespace Order_CRUD.IService
{
    public interface IOrderService
    {
        Task<OrderResponseDTO> AddOrder(OrderRequestDTO orderRequestDTO);
    }
}
