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
    }
}
