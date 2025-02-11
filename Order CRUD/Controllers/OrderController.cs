using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.IService;

namespace Order_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("Add-Order")]
        public async Task<IActionResult> AddOrder(OrderRequestDTO orderRequestDTO)
        {
            try
            {
                await _orderService.AddOrder(orderRequestDTO);
                return Ok(orderRequestDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Get-Order/{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            try
            {
                var orderData = await _orderService.GetOrder(id);
                return Ok(orderData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update-Order/{id}")]
        public async Task<IActionResult> UpdateOrder(int id, OrderRequestDTO orderRequestDTO)
        {
            try
            {
                var updateData = await _orderService.UpdateOrder(id, orderRequestDTO);
                return Ok(updateData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete-order/{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                var delData = await _orderService.DeleteOrder(id);
                return Ok(delData);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    } 
}
