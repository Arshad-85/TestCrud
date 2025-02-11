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
        public async Task<Product> GetProduct(int id)
        {
            var getProduct = await _orderDBContext.Products.FindAsync(id);
            return getProduct;
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            var updateProduct = _orderDBContext.Products.Update(product);
            await _orderDBContext.SaveChangesAsync();
            return updateProduct.Entity;
        }
    }
}
