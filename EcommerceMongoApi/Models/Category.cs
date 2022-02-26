using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EcommerceMongoApi.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public Guid ParentId { get; set; }
    }
}
