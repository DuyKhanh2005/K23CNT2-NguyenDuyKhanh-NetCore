using Microsoft.AspNetCore.Mvc;
using NdkDay03BT.Data;
using NdkDay03BT.Models;
using System.Linq;
using YourNamespace.Models;

namespace NdkDay03BT.Controllers
{
    public class ProductController : Controller
    {
        // Hiển thị danh sách sản phẩm
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }

        // Xem chi tiết sản phẩm
        public IActionResult Details(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // Thêm sản phẩm (GET)
        public IActionResult Create()
        {
            return View();
        }

        // Thêm sản phẩm (POST)
        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = ProductRepository.Products.Max(p => p.Id) + 1;
            ProductRepository.Products.Add(product);
            return RedirectToAction("Index");
        }

        // Sửa sản phẩm (GET)
        public IActionResult Edit(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // Sửa sản phẩm (POST)
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var existingProduct = ProductRepository.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            // Cập nhật thông tin sản phẩm
            existingProduct.Name = product.Name;
            existingProduct.ImageUrl = product.ImageUrl;
            existingProduct.Code = product.Code;
            existingProduct.Price = product.Price;
            existingProduct.Category = product.Category;
            existingProduct.Description = product.Description;

            return RedirectToAction("Index");
        }

        // Xóa sản phẩm (GET)
        public IActionResult Delete(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // Xóa sản phẩm (POST)
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            ProductRepository.Products.Remove(product);
            return RedirectToAction("Index");
        }
    }
}