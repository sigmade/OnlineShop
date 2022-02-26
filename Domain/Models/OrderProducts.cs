namespace Domain.Models
{
    public class OrderProducts
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
