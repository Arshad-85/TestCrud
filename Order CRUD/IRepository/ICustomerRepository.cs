using Order_CRUD.Entity;

namespace Order_CRUD.IRepository
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> GetCustomer(int id);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<string> DeleteCustomer(Customer customer);
    }
}
