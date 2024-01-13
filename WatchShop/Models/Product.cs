using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NAme { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Specification { get; set; }
    }
}
