using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Services
{
    public class ProductService
    {
        List<Product> _inMemoryProducts;
        public ProductService()
        {
            _inMemoryProducts = new List<Product>
            {
                new Product{Id=1,NAme="test1",Description="Michael Kors Men's Slim Runway Stainless Steel Quartz Watch",ImageUrl="https://m.media-amazon.com/images/I/61xSjdpeU0L._AC_UL320_.jpg",Price=35,Specification=""},
            new Product{Id=2,NAme="test2",Description="Timex Unisex Weekender 38mm Watch",ImageUrl="https://m.media-amazon.com/images/I/61xSjdpeU0L._AC_UL320_.jpg",Price=35,Specification=""},
            new Product{Id=3,NAme="test3",Description="Amazfit Band 5 Activity Fitness Tracker with Alexa Built-in, 15-Day Battery Life, Blood Oxygen, Heart Rate, Sleep & Stress Monitoring, 5 ATM Water Resistant",ImageUrl="https://m.media-amazon.com/images/I/61xSjdpeU0L._AC_UL320_.jpg",Price=35,Specification=""},
            new Product{Id=4,NAme="test4",Description="OUPINKE Skeleton Watches Mens Automatic Mechanical Self Winding Wrist Watch Luxury Sapphire Crystal Tungsten Steel Waterproof Luminous Premium Dress Watch",ImageUrl="https://m.media-amazon.com/images/I/61xSjdpeU0L._AC_UL320_.jpg",Price=35,Specification=""},
            new Product{Id=5,NAme="test5",Description="OUPINKE Men's Wrist Watches Automatic Mechanical Luxury Skeleton Self Winding Sapphire Crystal Waterproof Tungsten Steel Band",ImageUrl="https://m.media-amazon.com/images/I/61xSjdpeU0L._AC_UL320_.jpg",Price=35,Specification=""}
            };
        }
        public List<Product> GetProducts() => _inMemoryProducts;
        public Product GetProduct(int id) => _inMemoryProducts.FirstOrDefault(m => m.Id == id);
     
    }
}
