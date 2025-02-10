﻿using Microsoft.AspNetCore.Http;
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
    }
}