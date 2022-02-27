using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EcommerceMongoData.Models
{
    public class User : Document
    {
        [BsonElement("type_id")]
        public Guid TypeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
