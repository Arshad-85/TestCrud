using Order_CRUD.IService;

namespace Order_CRUD.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderService _orderService;
        public OrderService(IOrderService orderService)
        {
            _orderService = orderService;
        }
    }
}
