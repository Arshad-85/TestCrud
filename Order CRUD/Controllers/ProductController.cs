using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order_CRUD.IService;

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
    }
}
