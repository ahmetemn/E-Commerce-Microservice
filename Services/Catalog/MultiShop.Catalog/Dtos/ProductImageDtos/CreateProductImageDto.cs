namespace MultiShop.Catalog.Dtos.ProductImageDtos
{
    public class CreateProductImageDto
    {

        public List<string> Images { get; set; } = new List<string>(); // Dinamik fotoğraf listesi
        public string ProductId { get; set; }
    }
}
