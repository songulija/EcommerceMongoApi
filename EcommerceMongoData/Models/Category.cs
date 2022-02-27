using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EcommerceMongoData.Models
{
    //[BsonCollection] is custom attribute that i created. that allows to set
    //document collection name that it belongs to
    [BsonCollection("categories")]
    public class Category : Document
    {
        public string Title { get; set; }
        [BsonElement("parent_id"), BsonRepresentation(BsonType.ObjectId)]
        public string ParentId { get; set; }
    }
}
