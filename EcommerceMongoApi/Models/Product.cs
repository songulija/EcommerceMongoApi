using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        [BsonElement("user_id")]
        public Guid UserId { get; set; }
        [BsonElement("category_id")]
        public Guid CategoryId { get; set; }
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
    }
}
