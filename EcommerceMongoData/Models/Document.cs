using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceMongoData.Models
{
    public class Document : IDocument
    {
        public ObjectId Id { get; set; }
        //gets creation time derived from timestamp
        public DateTime CreatedAt => Id.CreationTime;
    }
}
