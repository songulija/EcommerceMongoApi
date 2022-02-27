using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EcommerceMongoData.Models
{
    //[BsonCollection] is custom attribute that i created. that allows to set
    //document collection name that it belongs to
    [BsonCollection("users")]
    public class User : Document
    {
        [BsonElement("type_id")]
        public Guid TypeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
