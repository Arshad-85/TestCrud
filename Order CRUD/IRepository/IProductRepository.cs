using Order_CRUD.Entity;

namespace Order_CRUD.IRepository
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
        Task<Product> GetProduct(int id);
        Task<Product> UpdateProduct(Product product);
    }
}
