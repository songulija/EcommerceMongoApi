using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace EcommerceMongoData.Models
{
    public class Order : Document
    {
        [BsonElement("user_id")]
        public Guid UserId { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        [BsonElement("payment_method")]
        public string PaymentMethod { get; set; }
        public PaymentResult PaymentResult { get; set; }
        [BsonElement("tax_price")]
        public int TaxPrice { get; set; }
        [BsonElement("shipping_price")]
        public int ShippingPrice { get; set; }
        [BsonElement("total_price")]
        public int TotalPrice { get; set; }
        [BsonElement("is_paid")]
        public bool IsPaid { get; set; }
        [BsonElement("paid_at")]
        public DateTime PaidAt { get; set; }
        [BsonElement("is_delivered")]
        public bool IsDelivered { get; set; }
        [BsonElement("delivered_at")]
        public DateTime? DeliveredAt { get; set; }
    }
}
