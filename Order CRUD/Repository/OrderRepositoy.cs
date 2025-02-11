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

        public async Task<Order> GetOrder(int id)
        {
            var getorder = await _orderDBContext.Orders.FindAsync(id);
            return getorder;
        }

        public async Task<Order> UpdateOrder(Order order)
        {
            var updateorder = _orderDBContext.Orders.Update(order);
            await _orderDBContext.SaveChangesAsync();
            return updateorder.Entity;
        }

        public async Task<string> DeleteOrder(Order order)
        {
            _orderDBContext.Orders.Remove(order);
            await _orderDBContext.SaveChangesAsync();
            return "Successfully Deleted";
        }
    }
}
