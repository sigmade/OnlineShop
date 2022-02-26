using Domain.Models.Enums;
using System;

namespace Domain.Models
{
    public class OrderHistory
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public OrderStatus Status { get; set; }
    }
}
