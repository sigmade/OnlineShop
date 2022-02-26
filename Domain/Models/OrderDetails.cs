namespace Domain.Models
{
    public class OrderDetails
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long CustomerId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CardNumber { get; set; }
    }
}
