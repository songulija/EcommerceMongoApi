using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EcommerceMongoData.Models
{
    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        //reference to Product
        [BsonElement("product_id"), BsonRepresentation(BsonType.ObjectId)]
        public string ProductId{ get; set; }
    }
}
