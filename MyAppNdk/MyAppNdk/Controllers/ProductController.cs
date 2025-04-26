using Microsoft.AspNetCore.Mvc;
using MyAppNdk.Models;

namespace MyAppNdk.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Dirty Coin Tee 1", Price = 520000, CreatedAt = DateTime.Now, Image = "/Images/tee1.jpg" },
                new Product { Id = 2, Name = "Dirty Coin Tee 2", Price = 550000, CreatedAt = DateTime.Now, Image = "/Images/tee2.jpg" },
                new Product { Id = 3, Name = "Dirty Coin Tee 3", Price = 520000, CreatedAt = DateTime.Now, Image = "/Images/tee3.jpg" },
                new Product { Id = 4, Name = "Dirty Coin Tee 4", Price = 530000, CreatedAt = DateTime.Now, Image = "/Images/tee4.jpg" }
            };

            return View(products);
        }
    }
}
