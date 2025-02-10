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
    }
}
