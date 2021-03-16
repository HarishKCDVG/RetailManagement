using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailManagement.Model
{
    public class Product
    {
        //[Required]
        public Guid ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
