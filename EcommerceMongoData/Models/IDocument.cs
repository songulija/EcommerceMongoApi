using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceMongoData.Models
{
    /// <summary>
    /// I created a class and interface that contains base information about each document
    /// </summary>
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
        //can only get CreatedAt not set
        DateTime CreatedAt { get; }
    }
}
