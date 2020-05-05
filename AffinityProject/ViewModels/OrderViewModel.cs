using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffinityProject.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ItemDescription { get; set; }
    }
}
