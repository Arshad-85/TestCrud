using Order_CRUD.Entity;
using Order_CRUD.IRepository;

namespace Order_CRUD.Repository
{
    public class OrderRepositoy : IOrderRepository
    {
        private readonly OrderDBContext _orderDBContext;
        public OrderRepositoy(OrderDBContext orderDBContext)
        {
            _orderDBContext = orderDBContext;
        }

        public async Task<Order> AddOrder(Order order)
        {
            var addorder = await _orderDBContext.Orders.AddAsync(order);
            await _orderDBContext.SaveChangesAsync();
            return addorder.Entity;
        }

        public async Task<Order> Getorder(int id)
        {
            var getorder = await _orderDBContext.Orders.FindAsync(id);
            return getorder;
        }

        public async Task<Order> Updateorder(Order customer)
        {
            var updateorder = _orderDBContext.Orders.Update(customer);
            await _orderDBContext.SaveChangesAsync();
            return updateorder.Entity;
        }

        public async Task<string> Deleteorder(Order customer)
        {
            _orderDBContext.Orders.Remove(customer);
            await _orderDBContext.SaveChangesAsync();
            return "Successfully Deleted";
        }
    }
}
