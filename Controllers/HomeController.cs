using Microsoft.AspNetCore.Mvc;
using AmazonSa.Models;
using System.Collections.Generic;
using System.Linq;

namespace AmazonSa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Fetch products from ProductController
            var featuredProducts = ProductController._products?.Take(3).ToList() ?? new List<Product>();

            return View(featuredProducts);
        }
    }
}
