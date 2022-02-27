using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceMongoData.Models
{
    /// <summary>
    /// I created a class and interface that contains base information about each document
    /// settings Created at time to when Id was created
    /// </summary>
    public class Document : IDocument
    {
        public string Id { get; set; }
        //gets creation time derived from timestamp
        public DateTime CreatedAt => DateTime.Now;
    }
}
