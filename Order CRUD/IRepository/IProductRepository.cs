using Order_CRUD.Entity;

namespace Order_CRUD.IRepository
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
    }
}
