using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EcommerceMongoData.Models
{
    public class UserType : Document
    {
        public string Title { get; set; }
    }
}
