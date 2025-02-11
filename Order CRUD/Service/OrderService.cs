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

        public async Task<OrderResponseDTO> GetOrder(int id)
        {
            var Order = await _orderRepository.GetOrder(id);
            var orderResponseDTO = new OrderResponseDTO();
            orderResponseDTO.Id = Order.Id;
            orderResponseDTO.CustomerId = Order.CustomerId;
            orderResponseDTO.ProductId = Order.ProductId;
            orderResponseDTO.Quantity = Order.Quantity;
            orderResponseDTO.TotalPrice = Order.TotalPrice;
            return orderResponseDTO;
        }

        public async Task<OrderResponseDTO> UpdateOrder(int id, OrderRequestDTO OrderRequestDTO)
        {
            var Order = await _orderRepository.GetOrder(id);
            if (Order == null)
            {
                throw new Exception("Order Not Found");
            }

            Order.CustomerId = OrderRequestDTO.CustomerId;
            Order.ProductId = OrderRequestDTO.ProductId;
            Order.Quantity = OrderRequestDTO.Quantity;
            Order.TotalPrice = OrderRequestDTO.TotalPrice;

            var newcus = await _orderRepository.UpdateOrder(Order);
            var cusResponseDTO = new OrderResponseDTO();
            cusResponseDTO.CustomerId = newcus.CustomerId;
            cusResponseDTO.ProductId = newcus.ProductId;
            cusResponseDTO.Quantity = newcus.Quantity;
            cusResponseDTO.TotalPrice = newcus.TotalPrice;
            cusResponseDTO.OrderDate = newcus.OrderDate;
            cusResponseDTO.Status = newcus.Status;
            return cusResponseDTO;
        }

        public async Task<string> DeleteOrder(int id)
        {
            var Order = await _orderRepository.GetOrder(id);
            if (Order == null)
            {
                throw new Exception("Order Not Found");
            }
            var result = await _orderRepository.DeleteOrder(Order);
            return result;
        }
    }
}
