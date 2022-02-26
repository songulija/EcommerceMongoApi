using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EcommerceMongoData.Models
{
    public class PaymentResult
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Status { get; set; }
        [BsonElement("update_time")]
        public string UpdateTime { get; set; }
        [BsonElement("email_address")]
        public string EmailAddress { get; set; }
    }
}
