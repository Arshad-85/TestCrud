using Order_CRUD.IRepository;

namespace Order_CRUD.Repository
{
    public class OrderRepositoy : IOrderRepository
    {
        private readonly IOrderRepository _orderRepository;
        public OrderRepositoy(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}
