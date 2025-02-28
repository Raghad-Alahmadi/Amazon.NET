using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmazonSa.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazonSa.Controllers
{
    public class OrderController : Controller
    {
        // Simulated database
        private static List<Order> _orders = new List<Order>();
        private readonly ILogger<OrderController> _logger;

        // Constructor
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet("Order/PlaceOrder/{productId}")]
        public IActionResult PlaceOrder(int productId)
        {
            // Get product details
            var product = ProductController._products?.FirstOrDefault(p => p.ProductId == productId);
            if (product == null) // if product not found
            {
                TempData["ErrorMessage"] = "Product not found.";
                return RedirectToAction("ErrorPage");
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromForm] int productId, [FromForm] int quantity)
        {
            // Validate and process order
            try
            {
                if (productId <= 0 || quantity <= 0)
                {
                    TempData["ErrorMessage"] = "Invalid product ID or quantity.";
                    return RedirectToAction("PlaceOrder", new { productId });
                }

                var product = ProductController._products?.FirstOrDefault(p => p.ProductId == productId);
                if (product == null)
                {
                    TempData["ErrorMessage"] = "Product not found.";
                    return RedirectToAction("PlaceOrder", new { productId });
                }

                if (product.StockQuantity < quantity)
                {
                    TempData["ErrorMessage"] = "Insufficient stock available!";
                    return RedirectToAction("PlaceOrder", new { productId });
                }

                // Create order
                var order = new Order
                {
                    OrderId = _orders.Count + 1,
                    UserId = 1, // Simulated logged-in user
                    OrderDate = DateTime.Now,
                    OrderDetails = new List<OrderDetail>
                    {
                        new OrderDetail { ProductId = productId, Quantity = quantity, SubTotal = product.Price * quantity }
                    }
                };
                _orders.Add(order);

                // Update stock
                product.StockQuantity -= quantity;
                return RedirectToAction("History", new { userId = 1 });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the order.");
                TempData["ErrorMessage"] = "An unexpected error occurred.";
                return RedirectToAction("PlaceOrder", new { productId });
            }
        }

        [HttpGet("Orders/{userId}")]
        public IActionResult History(int userId)
        {
            var userOrders = _orders.Where(o => o.UserId == userId).ToList();
            return View(userOrders);
        }

        public IActionResult ErrorPage()
        {
            return View();
        }
    }
}
