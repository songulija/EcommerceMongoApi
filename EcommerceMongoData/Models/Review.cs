using MongoDB.Bson.Serialization.Attributes;

namespace EcommerceMongoData.Models
{
    public class Review
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        [BsonElement("user_id")]
        public string UserId { get; set; }

    }
}
