using System;
using System.Collections.Generic;

namespace DataContext.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ItemDescription { get; set; }

        public Order Order { get; set; }
    }
}
