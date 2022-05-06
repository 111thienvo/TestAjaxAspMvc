using DemoSs10_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSs10_mvc.Services
{
    public interface ProductService
    {
        List<Product> FindAll();

        List<Product> Search(string keyword);

        List<Product> Search(double min,double max);

        List<string> SearchByKeword(string keyword);


    }
}
