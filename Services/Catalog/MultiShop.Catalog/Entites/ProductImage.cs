namespace MultiShop.Catalog.Entites
{
    public class ProductImage
    {
        public string ProductImageId { get; set; }

        public List<string> Images { get; set; } = new List<string>(); // Dinamik fotoğraf listesi
        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}
