using Order_CRUD.Entity;

namespace Order_CRUD.IRepository
{
    public interface ICustomerRepository
    {
        Task<Customer> AddCustomer(Customer customer);
    }
}
