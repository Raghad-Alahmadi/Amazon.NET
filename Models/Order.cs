using System;
using System.Collections.Generic;

namespace AmazonSa.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}