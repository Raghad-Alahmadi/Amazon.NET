using Microsoft.AspNetCore.Mvc;
using AmazonSa.Models;
using System.Collections.Generic;

namespace AmazonSa.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> _products = new List<Product>
        {
            // Sample products
            new Product { ProductId = 1, Name = "Laptop", Category = "Electronics", Price = 1200, StockQuantity = 10 },
            new Product { ProductId = 2, Name = "Smartphone", Category = "Electronics", Price = 800, StockQuantity = 15 },
            new Product { ProductId = 3, Name = "Tablet", Category = "Electronics", Price = 500, StockQuantity = 20 },
            new Product { ProductId = 4, Name = "Smartwatch", Category = "Electronics", Price = 300, StockQuantity = 25 },
            new Product { ProductId = 5, Name = "Headphones", Category = "Electronics", Price = 150, StockQuantity = 30 },
            new Product { ProductId = 6, Name = "Wireless Mouse", Category = "Accessories", Price = 50, StockQuantity = 40 },
            new Product { ProductId = 7, Name = "Mechanical Keyboard", Category = "Accessories", Price = 100, StockQuantity = 35 },
            new Product { ProductId = 8, Name = "Monitor", Category = "Electronics", Price = 250, StockQuantity = 20 },
            new Product { ProductId = 9, Name = "Gaming Chair", Category = "Furniture", Price = 350, StockQuantity = 10 },
            new Product { ProductId = 10, Name = "External Hard Drive", Category = "Storage", Price = 120, StockQuantity = 25 },
            new Product { ProductId = 11, Name = "USB Flash Drive", Category = "Storage", Price = 20, StockQuantity = 100 },
            new Product { ProductId = 12, Name = "Router", Category = "Networking", Price = 180, StockQuantity = 15 },
            new Product { ProductId = 13, Name = "Bluetooth Speaker", Category = "Audio", Price = 80, StockQuantity = 40 },
            new Product { ProductId = 14, Name = "Graphics Card", Category = "Components", Price = 600, StockQuantity = 5 },
            new Product { ProductId = 15, Name = "Processor", Category = "Components", Price = 300, StockQuantity = 8 },
            new Product { ProductId = 16, Name = "RAM 16GB", Category = "Components", Price = 150, StockQuantity = 20 },
            new Product { ProductId = 17, Name = "Motherboard", Category = "Components", Price = 200, StockQuantity = 10 },
            new Product { ProductId = 18, Name = "Power Bank", Category = "Accessories", Price = 50, StockQuantity = 50 },
            new Product { ProductId = 19, Name = "Gaming Console", Category = "Gaming", Price = 500, StockQuantity = 12 },
            new Product { ProductId = 20, Name = "VR Headset", Category = "Gaming", Price = 400, StockQuantity = 7 },
            new Product { ProductId = 21, Name = "Smart TV", Category = "Electronics", Price = 1000, StockQuantity = 8 },
            new Product { ProductId = 22, Name = "Washing Machine", Category = "Home Appliances", Price = 700, StockQuantity = 6 },
            new Product { ProductId = 23, Name = "Refrigerator", Category = "Home Appliances", Price = 900, StockQuantity = 5 },
            new Product { ProductId = 24, Name = "Microwave Oven", Category = "Home Appliances", Price = 250, StockQuantity = 10 },
            new Product { ProductId = 25, Name = "Coffee Maker", Category = "Kitchen", Price = 100, StockQuantity = 20 },
            new Product { ProductId = 26, Name = "Blender", Category = "Kitchen", Price = 80, StockQuantity = 30 },
            new Product { ProductId = 27, Name = "Air Purifier", Category = "Home Appliances", Price = 300, StockQuantity = 10 },
            new Product { ProductId = 28, Name = "Electric Shaver", Category = "Personal Care", Price = 60, StockQuantity = 25 },
            new Product { ProductId = 29, Name = "Hair Dryer", Category = "Personal Care", Price = 50, StockQuantity = 30 },
            new Product { ProductId = 30, Name = "Smart Light Bulb", Category = "Smart Home", Price = 25, StockQuantity = 100 },
            new Product { ProductId = 31, Name = "Security Camera", Category = "Smart Home", Price = 150, StockQuantity = 20 },
            new Product { ProductId = 32, Name = "Drone", Category = "Gadgets", Price = 800, StockQuantity = 5 },
            new Product { ProductId = 33, Name = "Portable Projector", Category = "Gadgets", Price = 350, StockQuantity = 10 },
            new Product { ProductId = 34, Name = "E-Reader", Category = "Electronics", Price = 200, StockQuantity = 15 },
            new Product { ProductId = 35, Name = "Digital Camera", Category = "Photography", Price = 700, StockQuantity = 8 },
            new Product { ProductId = 36, Name = "Tripod", Category = "Photography", Price = 100, StockQuantity = 30 },
            new Product { ProductId = 37, Name = "Fitness Tracker", Category = "Wearables", Price = 120, StockQuantity = 25 },
            new Product { ProductId = 38, Name = "Action Camera", Category = "Photography", Price = 400, StockQuantity = 10 },
            new Product { ProductId = 39, Name = "Electric Scooter", Category = "Transport", Price = 600, StockQuantity = 10 },
            new Product { ProductId = 40, Name = "Car Dash Cam", Category = "Automotive", Price = 150, StockQuantity = 15 },
            new Product { ProductId = 41, Name = "Wireless Earbuds", Category = "Audio", Price = 100, StockQuantity = 50 },
            new Product { ProductId = 42, Name = "Gaming Mouse Pad", Category = "Accessories", Price = 30, StockQuantity = 40 },
            new Product { ProductId = 43, Name = "Portable Charger", Category = "Accessories", Price = 40, StockQuantity = 50 },
            new Product { ProductId = 44, Name = "Cordless Vacuum Cleaner", Category = "Home Appliances", Price = 250, StockQuantity = 12 },
            new Product { ProductId = 45, Name = "Surge Protector", Category = "Accessories", Price = 40, StockQuantity = 50 },
            new Product { ProductId = 46, Name = "Ergonomic Chair", Category = "Furniture", Price = 500, StockQuantity = 8 },
            new Product { ProductId = 47, Name = "Smart Door Lock", Category = "Smart Home", Price = 200, StockQuantity = 15 },
            new Product { ProductId = 48, Name = "Adjustable Standing Desk", Category = "Furniture", Price = 450, StockQuantity = 5 },
            new Product { ProductId = 49, Name = "Streaming Webcam", Category = "Electronics", Price = 120, StockQuantity = 20 },
            new Product { ProductId = 50, Name = "Graphics Tablet", Category = "Electronics", Price = 350, StockQuantity = 10 }
        };

        [HttpGet("/Products")]
        public IActionResult Index()
        {
            return View(_products);
        }
    }
}