using Order_CRUD.Entity;

namespace Order_CRUD.IRepository
{
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
        //Task<Order> Getorder(int id);
        //Task<Order> Updateorder(Order customer);
        //Task<string> Deleteorder(Order customer);
    }
}
