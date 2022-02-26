using Domain.Models.Enums;
using System;

namespace Domain.Models
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
    }
}
