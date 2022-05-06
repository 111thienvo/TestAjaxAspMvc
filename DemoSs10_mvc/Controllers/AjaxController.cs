using DemoSs10_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSs10_mvc.Controllers
{
    [Route("ajax")]
    public class AjaxController : Controller
    {
        [Route("demo1")]
        public ContentResult Demo1()
        {
            return Content("Demo 1","text/plain");
        }

        [Route("demo2")]
        public ContentResult Demo2()
        {
            return Content("<b><i><u>Demo 2</u></i></b>", "text/html");
        }

        [Route("demo3")]
        public ContentResult Demo3([FromQuery(Name ="name")] string name)
        {
            return Content("Hello " + name, "text/plain");
        }

        [HttpPost]
        [Route("demo4")]
        public ContentResult Demo4( string name)
        {
            return Content("Hello " + name, "text/plain");
        }

        [Route("demo5")]
        public IActionResult Demo5( )
        {
            var product = new Product()
            {
                Id = "p01",
                Name = "Name 1",
                Price = 3
            };
            return new JsonResult(product);
        }
        [Route("demo6")]
        public IActionResult Demo6()
        {
            var products = new List<Product>
            { 
                new Product{
                Id = "p01",
                Name = "Name 1",
                Price = 3
                },
                 new Product{
                Id = "p02",
                Name = "Name 2",
                Price = 3.5
                },
                  new Product{
                Id = "p03",
                Name = "Name 3",
                Price = 5
                }
            };
            return new JsonResult(products);
        }

        
    }
}
