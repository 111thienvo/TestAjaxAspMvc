using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_ASPNETCoreMVC.Models
{
    public class ProductModel
    {
        public List<Product> Products;
        public ProductModel()
        {
            Products = new List<Product>
            {
                new Product { Id = "p01", Name = "Tivi 1", Photo = "img1.jpg", Price = 2 , CategoryId = "c1"},
                 new Product { Id = "p02", Name = "Tivi 2", Photo = "img2.jpg", Price = 5 , CategoryId = "c2"},
                  new Product { Id = "p03", Name = "Tivi 3", Photo = "img3.jpg", Price = 9 , CategoryId = "c3"},
                   new Product { Id = "p04", Name = "Tivi 4", Photo = "img4.jpg", Price = 11 , CategoryId = "c4"}
            };
        }

        public List<string> Search(string keyword)
        {
            return Products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).Select(p => p.Name).ToList();
        }
        public List<Product> Search2(string keyword)
        {
            return Products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}
