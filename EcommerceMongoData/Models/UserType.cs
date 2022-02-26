using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EcommerceMongoData.Models
{
    public class UserType
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
