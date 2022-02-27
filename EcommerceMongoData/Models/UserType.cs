using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EcommerceMongoData.Models
{
    //[BsonCollection] is custom attribute that i created. that allows to set
    //document collection name that it belongs to
    [BsonCollection("user-types")]
    public class UserType : Document
    {
        public string Title { get; set; }
    }
}
