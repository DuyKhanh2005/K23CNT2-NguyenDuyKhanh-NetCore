using NdkDay03BT.Models;

namespace NdkDay03BT.Data
{
    public static class ProductRepository
    {
        public static List<Product> Products = new List<Product>
        {
            new Product {
                Id = 1,
                Name = "iPhone 16 màu Xanh lá",
                ImageUrl = "/images/product1.jpg",
                Code = "991",
                Price = 200000,
                Category = "Công nghệ",
                Description = "Chiếc iPhone 16 với màu xanh lá tuyệt đẹp, cấu hình mạnh mẽ, pin bền bỉ."
            },
            new Product {
                Id = 2,
                Name = "iPhone 16 màu Xanh dương",
                ImageUrl = "/images/product2.jpg",
                Code = "895",
                Price = 250000,
                Category = "Công nghệ",
                Description = "Phiên bản iPhone 16 màu xanh dương, phù hợp cho mọi phong cách thời trang."
            },
            new Product {
                Id = 3,
                Name = "iPhone 16 màu Vàng",
                ImageUrl = "/images/product3.jpg",
                Code = "768",
                Price = 350000,
                Category = "Công nghệ",
                Description = "iPhone 16 màu vàng sang trọng, nổi bật với thiết kế hiện đại."
            },
            new Product {
                Id = 4,
                Name = "iPhone 16 màu Đen",
                ImageUrl = "/images/product4.jpg",
                Code = "111",
                Price = 400000,
                Category = "Công nghệ",
                Description = "Màu đen lịch lãm, iPhone 16 mang lại trải nghiệm cao cấp."
            }
        };
    }
}