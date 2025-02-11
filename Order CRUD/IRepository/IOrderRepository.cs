using Order_CRUD.Entity;

namespace Order_CRUD.IRepository
{
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
        Task<Order> GetOrder(int id);
        Task<Order> UpdateOrder(Order customer);
        Task<string> DeleteOrder(Order order);
    }
}
