using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entites
{
    public class ProductImage
    {

        //Id olduğunu belirtmek için mongodb böyle kullaanılır 
        [BsonId]
        //Benzersiz olduğunu bildirmek için kullanılır 
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductImageId { get; set; }

        public List<string> Images { get; set; } = new List<string>(); // Dinamik fotoğraf listesi
        public string ProductId { get; set; }

        [BsonIgnore]
        //bu öznitelikle işaretlenmiş özellikler işleme dahil edilmez.
        //Entity Framework Core'da [NotMapped] 
        public Product Product { get; set; }
    }
}
