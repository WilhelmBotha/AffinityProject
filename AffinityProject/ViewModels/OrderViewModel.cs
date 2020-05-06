using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DataContext.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AffinityProject.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ItemDescription { get; set; }

        public IEnumerable<SelectListItem> AvailableCustomers { get; set; }
    }
}
