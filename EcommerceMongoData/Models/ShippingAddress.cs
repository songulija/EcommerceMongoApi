using MongoDB.Bson.Serialization.Attributes;

namespace EcommerceMongoData.Models
{
    public class ShippingAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        [BsonElement("post_code")]
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}
