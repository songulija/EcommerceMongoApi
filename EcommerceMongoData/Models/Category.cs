using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EcommerceMongoData.Models
{
    public class Category : Document
    {
        public string Title { get; set; }
        [BsonElement("parent_id")]
        public Guid ParentId { get; set; }
    }
}
