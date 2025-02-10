using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order_CRUD.DTOs.ReqestDTO;
using Order_CRUD.IService;
using Order_CRUD.Service;

namespace Order_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("Add-Product")]
        public async Task<IActionResult> AddProduct(ProductRequestDTO productRequestDTO)
        {
            var data = await _productService.AddProduct(productRequestDTO);
            return Ok(data);
        }
    }
}
