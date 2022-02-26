using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    public class Review
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        [BsonElement("user_id")]
        public string UserId { get; set; }

    }
}
