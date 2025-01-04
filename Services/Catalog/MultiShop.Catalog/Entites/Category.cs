using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entites
{
    public class Category
    {
        //Id olduğunu belirtmek için mongodb böyle kullaanılır 
        [BsonId]
        //Benzersiz olduğunu bildirmek için kullanılır 
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
