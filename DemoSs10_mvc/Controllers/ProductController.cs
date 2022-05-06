using DemoSs10_mvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSs10_mvc.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private ProductService productService;
        public ProductController(ProductService _productService)
        {
            productService = _productService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.products = productService.FindAll();
            return View();
        }

        [HttpPost]
        [Route("search")]
        public IActionResult Search(string category)
        {
            if (category.Equals("all"))
            {
                return new JsonResult(productService.FindAll());
            }
            else
            {
                return new JsonResult(productService.Search(category));
            }

        }

        [HttpPost]
        [Route("searchminmax")]
        public IActionResult Search(double min, double max)
        {
            return new JsonResult(productService.Search(min, max));
        }


        [Route("searcByKeyword")]
        public IActionResult SearchByKeyword([FromQuery(Name = "term")] string term)
        {
            return new JsonResult(productService.SearchByKeword(term));
        }
    }
   
}


    
   

