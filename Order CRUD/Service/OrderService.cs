using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.DTOs.ResponseDTO;
using Order_CRUD.Entity;
using Order_CRUD.IRepository;
using Order_CRUD.IService;

namespace Order_CRUD.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<OrderResponseDTO> AddOrder(OrderRequestDTO orderRequestDTO)
        {
            var Order = new Order();
            Order.CustomerId = orderRequestDTO.CustomerId;
            Order.ProductId= orderRequestDTO.ProductId;
            Order.TotalPrice = orderRequestDTO.TotalPrice;
            Order.Quantity = orderRequestDTO.Quantity;
            Order.OrderDate = DateTime.Now;

            var newOrder = await _orderRepository.AddOrder(Order);
            var orderResponseDTO = new OrderResponseDTO();
            orderResponseDTO.CustomerId = newOrder.CustomerId;
            orderResponseDTO.ProductId = newOrder.ProductId;
            orderResponseDTO.TotalPrice = newOrder.TotalPrice;
            orderResponseDTO.Quantity = newOrder.Quantity;
            orderResponseDTO.OrderDate = newOrder.OrderDate;
            return orderResponseDTO;
        }

        //public async Task<OrderResponseDTO> GetOrder(int id)
        //{
        //    var Order = await _OrderRepository.GetOrder(id);
        //    var cusResponseDTO = new OrderResponseDTO();
        //    cusResponseDTO.Name = Order.Name;
        //    cusResponseDTO.Phone = Order.Phone;
        //    cusResponseDTO.Address = Order.Address;
        //    cusResponseDTO.Email = Order.Email;
        //    return cusResponseDTO;
        //}

        //public async Task<OrderResponseDTO> UpdateOrder(int id, OrderRequestDTO OrderRequestDTO)
        //{
        //    var Order = await _orderService.GetOrder(id);
        //    if (Order == null)
        //    {
        //        throw new Exception("Order Not Found");
        //    }

        //    Order.Name = OrderRequestDTO.Name;
        //    Order.Email = OrderRequestDTO.Email;
        //    Order.Phone = OrderRequestDTO.Phone;
        //    Order.Address = OrderRequestDTO.Address;

        //    var newcus = await _OrderRepository.UpdateOrder(Order);
        //    var cusResponseDTO = new OrderResponseDTO();
        //    cusResponseDTO.Name = newcus.Name;
        //    cusResponseDTO.Phone = newcus.Phone;
        //    cusResponseDTO.Address = newcus.Address;
        //    cusResponseDTO.Email = newcus.Email;
        //    return cusResponseDTO;
        //}

        //public async Task<string> DeleteOrder(int id)
        //{
        //    var Order = await _OrderRepository.GetOrder(id);
        //    if (Order == null)
        //    {
        //        throw new Exception("Order Not Found");
        //    }
        //    var result = await _OrderRepository.DeleteOrder(Order);
        //    return result;
        //}
    }
}
