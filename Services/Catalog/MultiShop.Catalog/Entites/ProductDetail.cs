using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entites
{
    public class ProductDetail
    {


        //Id olduğunu belirtmek için mongodb böyle kullaanılır 
        [BsonId]
        //Benzersiz olduğunu bildirmek için kullanılır 
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductInfo { get; set; }

        public string ProductId { get; set; }

        [BsonIgnore]
        //bu öznitelikle işaretlenmiş özellikler işleme dahil edilmez.
        //Entity Framework Core'da [NotMapped] 
        public Product Product { get; set; }

    }
}
