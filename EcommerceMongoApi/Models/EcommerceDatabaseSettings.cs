using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    /// <summary>
    /// The preceding BookStoreDatabaseSettings class is used to store the appsettings.json file's BookStoreDatabase property values
    /// The JSON and C# property names are named identically to ease the mapping process.
    /// </summary>
    public class EcommerceDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; }
        public string CategoriesCollectionName { get; set; }
        public string UserTypesCollectionName { get; set; }
        public string UsersCollection { get; set; }
        public string ProductCollectionName { get; set; }
        public string OrdersCollectionName { get; set; }
    }
}
