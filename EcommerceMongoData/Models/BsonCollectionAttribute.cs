using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceMongoData.Models
{
    /// <summary>
    /// Mongo Driver lacks attribute that allows us to set the collection 
    /// name for documents, so I created one. Created new Attribute
    /// [BsonCollection("..."] for documents to assign collection names
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BsonCollectionAttribute : Attribute
    {
        public string CollectionName { get; set; }
        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
