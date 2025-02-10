using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;
using Order_CRUD.Entity;

namespace Order_CRUD.IService
{
    public interface ICustomerService
    {
        Task<CustomerResponseDTO> AddCustomer(CustomerRequestDTO customerRequestDTO);
        Task<CustomerResponseDTO> GetCustomer(int id);
        Task<CustomerResponseDTO> UpdateCustomer(int id, CustomerRequestDTO customerRequestDTO);
        Task<string> DeleteCustomer(int id);
    }
}
