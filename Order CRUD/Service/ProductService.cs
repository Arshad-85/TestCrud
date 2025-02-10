using Order_CRUD.IService;

namespace Order_CRUD.Service
{
    public class ProductService: IProductService
    {
        private readonly ProductService _productService;

        public ProductService(ProductService productService)
        {
            _productService = productService;
        }

    }
}
