using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace EcommerceMongoData.Models
{
    //[BsonCollection] is custom attribute that i created. that allows to set
    //document collection name that it belongs to
    [BsonCollection("products")]
    public class Product : Document
    {
        //reference to user that created
        [BsonElement("user_id"), BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
        [BsonElement("category_id"), BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public IList<Review> Reviews { get; set; }
        public double Rating { get; set; }
        [BsonElement("num_reviews")]
        public int NumReviews { get; set; }
        public int Price { get; set; }
        [BsonElement("count_in_stock")]
        public int CountInStock { get; set; }
        public string[] Tags { get; set; }
    }
}
