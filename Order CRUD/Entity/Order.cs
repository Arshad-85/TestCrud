namespace Order_CRUD.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public status Status { get; set; }
    }

    public enum status
    {
        pending = 1,
        completed = 2,
        cancelled = 3
    }
}
