using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;
using Order_CRUD.Entity;

namespace Order_CRUD.IService
{
    public interface ICustomerService
    {
        Task<CustomerResponseDTO> AddCustomer(CustomerRequestDTO customerRequestDTO);
    }
}
