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
        
        public async Task<Customer> GetCustomer(int id)
        {
            var getCustomer = await _orderDBContext.Customers.FindAsync(id);
            return getCustomer;
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            var cus = _orderDBContext.Customers.Update(customer);
            await _orderDBContext.SaveChangesAsync();
            return cus.Entity;
        }

        public async Task<string> DeleteCustomer(Customer customer)
        {
            _orderDBContext.Customers.Remove(customer);
            await _orderDBContext.SaveChangesAsync();
            return "Successfully Deleted";
        }
    }
}
