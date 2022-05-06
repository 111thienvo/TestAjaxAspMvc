using DemoSs10_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSs10_mvc.Services
{
    public class ProductServiceImpl : ProductService
    {
        public List<Product> FindAll()
        {
            var products = new List<Product>
            {
                new Product{
                Id = "p01",
                Name = "Tivi 1",
                Price = 3,
                Category ="Category 1"
                },
                 new Product{
                Id = "p02",
                Name = "Laptop 2",
                Price = 3.5,
                Category ="Category 2"
                },
                  new Product{
                Id = "p03",
                Name = "Laptop 3",
                Price = 5,
                Category ="Category 3"
                }
            };
            return products;
        }

        public List<Product> Search(string keyword)
        {
            return FindAll().Where(p => p.Category.ToLower().Contains(keyword.ToLower())).ToList();
        }
        public List<Product> Search(double min, double max)
        {
            return FindAll().Where(p => p.Price >= min && p.Price <= max).ToList();
        }

        public List<string> SearchByKeword(string keyword)
        {
            return FindAll().Where(p => p.Name.ToLower().Contains(keyword.ToLower())).Select(p =>p.Name).ToList();
        }
    
    }
}
