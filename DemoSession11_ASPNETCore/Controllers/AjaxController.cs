using DemoSession11_ASPNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession11_ASPNETCore.Controllers
{
    [Route("ajax")]
    public class AjaxController : Controller
    {
        [Route("demo1")]
        public IActionResult Demo1()
        {
            return Content("Hello Ajax", "text/plain");
        }

        [HttpPost]
        [Route("demo2")]
        public IActionResult Demo2()
        {
            return Content("Hello Ajax - POST", "text/plain");
        }

        [Route("demo3")]
        public IActionResult Demo3([FromQuery(Name = "name")] string name)
        {
            return Content("Hello " + name, "text/plain");
        }

        [Route("demo4/{fullName}")]
        public IActionResult Demo4(string fullName)
        {
            return Content("Hello " + fullName, "text/plain");
        }

        [HttpPost]
        [Route("demo5")]
        public IActionResult Demo5(string name)
        {
            return Content("Hello " + name, "text/plain");
        }

        [HttpPost]
        [Route("demo6")]
        public IActionResult Demo6(double a, double b)
        {
            return Content((a + b).ToString(), "text/plain");
        }

        [Route("demo7")]
        public IActionResult Demo7()
        {
            var product = new Product { 
                Id = "p01",
                Name = "Name 1",
                Price = 4.5
            };
            return new JsonResult(product);
        }

        [Route("demo8")]
        public IActionResult Demo8()
        {
            var products = new List<Product>
            {
                new Product {
                    Id = "p01",
                    Name = "Name 1",
                    Price = 4.5
                },
                new Product {
                    Id = "p02",
                    Name = "Name 2",
                    Price = 9
                },
                new Product {
                    Id = "p03",
                    Name = "Name 3",
                    Price = 11
                }
            };
            return new JsonResult(products);
        }

    }
}
