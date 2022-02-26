using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        //reference to Product
        [BsonElement("product_id")]
        public Guid ProductId { get; set; }
    }
}
