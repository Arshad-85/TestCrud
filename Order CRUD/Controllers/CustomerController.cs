using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.Entity;
using Order_CRUD.IService;

namespace Order_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("Add-Customer")]
        public async Task<IActionResult> AddCustomer(CustomerRequestDTO customerRequestDTO)
        {
            await _customerService.AddCustomer(customerRequestDTO);
            return Ok(customerRequestDTO);
        }

        [HttpGet("Get-Customer/{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _customerService.GetCustomer(id);
            return Ok(customer);
        }

        [HttpPut("Update-Customer/{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, CustomerRequestDTO customerRequestDTO)
        {
            try
            {
                var customer = await _customerService.UpdateCustomer(id, customerRequestDTO);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete-Customer/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            try
            {
                var customer = await _customerService.DeleteCustomer(id);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}