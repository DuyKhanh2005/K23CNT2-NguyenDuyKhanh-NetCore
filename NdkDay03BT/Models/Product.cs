namespace NdkDay03BT.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        // Mô tả sản phẩm
        public string Description { get; set; }
    }
}