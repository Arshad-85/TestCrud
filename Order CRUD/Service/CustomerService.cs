using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;
using Order_CRUD.Entity;
using Order_CRUD.IRepository;
using Order_CRUD.IService;

namespace Order_CRUD.Service
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerResponseDTO> AddCustomer(CustomerRequestDTO customerRequestDTO)
        {
            var customer = new Customer();
            customer.Name = customerRequestDTO.Name;
            customer.Email = customerRequestDTO.Email;
            customer.Phone = customerRequestDTO.Phone;
            customer.Address = customerRequestDTO.Address;
            customer.CreatedAt = DateTime.Now;

            var newcus =  await _customerRepository.AddCustomer(customer);
            var cusResponseDTO = new CustomerResponseDTO();
            cusResponseDTO.Name = newcus.Name;
            cusResponseDTO.Phone = newcus.Phone;
            cusResponseDTO.Address = newcus.Address;
            cusResponseDTO.Email = newcus.Email;
            return cusResponseDTO;
        }

        public async Task<CustomerResponseDTO> GetCustomer(int id)
        {
            var customer = await _customerRepository.GetCustomer(id);
            var cusResponseDTO = new CustomerResponseDTO();
            cusResponseDTO.Name = customer.Name;
            cusResponseDTO.Phone = customer.Phone;
            cusResponseDTO.Address = customer.Address;
            cusResponseDTO.Email = customer.Email;
            return cusResponseDTO;
        }

        public async Task<CustomerResponseDTO> UpdateCustomer(int id, CustomerRequestDTO customerRequestDTO)
        {
            var customer = await _customerRepository.GetCustomer(id);
            if(customer == null)
            {
                throw new Exception("Customer Not Found");
            }

            customer.Name = customerRequestDTO.Name;
            customer.Email = customerRequestDTO.Email;
            customer.Phone = customerRequestDTO.Phone;
            customer.Address = customerRequestDTO.Address;

            var newcus = await _customerRepository.UpdateCustomer(customer);
            var cusResponseDTO = new CustomerResponseDTO();
            cusResponseDTO.Name = newcus.Name;
            cusResponseDTO.Phone = newcus.Phone;
            cusResponseDTO.Address = newcus.Address;
            cusResponseDTO.Email = newcus.Email;
            return cusResponseDTO;
        }

        public async Task<string> DeleteCustomer(int id)
        {
            var customer = await _customerRepository.GetCustomer(id);
            if (customer == null)
            {
                throw new Exception("Customer Not Found");
            }
            var result = await _customerRepository.DeleteCustomer(customer);
            return result;
        }
    }
}
