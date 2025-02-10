using Order_CRUD.Entity;
using Order_CRUD.IRepository;

namespace Order_CRUD.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly OrderDBContext _orderDBContext;
        public ProductRepository(OrderDBContext orderDBContext)
        {
            _orderDBContext = orderDBContext;
        }
        public async Task<Product> AddProduct(Product product)
        {
            var cus = _orderDBContext.Products.Add(product);
            await _orderDBContext.SaveChangesAsync();
            return cus.Entity;
        }
    }
}
