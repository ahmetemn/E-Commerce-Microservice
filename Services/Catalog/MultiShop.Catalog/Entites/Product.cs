using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entites
{
    public class Product
    {
        //Id olduğunu belirtmek için mongodb böyle kullaanılır 
        [BsonId]
        //Benzersiz olduğunu bildirmek için kullanılır 
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string ProductImageUrl { get; set; }

        public string ProductDescription { get; set; }

        public string CategoryId { get; set; }

        [BsonIgnore]
        //bu öznitelikle işaretlenmiş özellikler işleme dahil edilmez.
        //Entity Framework Core'da [NotMapped] 
        public Category Category { get; set; }

    }
}
