using DemoSession12_ASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession12_ASPNETCoreMVC.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("search")]
        public IActionResult Search([FromQuery(Name = "term")] string term)
        {
            var productModel = new ProductModel();
            return new JsonResult(productModel.Search(term));
        }
        [Route("search2/{keyword}")]
        public IActionResult Search2(string keyword)
        {
            var productModel = new ProductModel();
            ViewBag.products = productModel.Search2(keyword);
            return View("Index2");
        }
    }
}
