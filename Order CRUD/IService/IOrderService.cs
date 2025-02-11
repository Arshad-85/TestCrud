using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;

namespace Order_CRUD.IService
{
    public interface IOrderService
    {
        Task<OrderResponseDTO> AddOrder(OrderRequestDTO orderRequestDTO);
        Task<OrderResponseDTO> GetOrder(int id);
        Task<OrderResponseDTO> UpdateOrder(int id, OrderRequestDTO OrderRequestDTO);
        Task<string> DeleteOrder(int id);
    }
}
