using Order_CRUD.Entity;
using Order_CRUD.IRepository;

namespace Order_CRUD.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly OrderDBContext _orderDBContext;

        public CustomerRepository(OrderDBContext orderDBContext)
        {
            _orderDBContext = orderDBContext;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
           var cus = _orderDBContext.Customers.Add(customer);
           await _orderDBContext.SaveChangesAsync();
           return cus.Entity;
        }

    }
}
