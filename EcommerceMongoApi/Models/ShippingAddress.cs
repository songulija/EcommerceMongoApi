using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    public class ShippingAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        [BsonElement("post_code")]
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}
