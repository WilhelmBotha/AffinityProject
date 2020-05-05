using System;
using System.Collections.Generic;

namespace DataContext.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
