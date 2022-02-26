using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public IList<Review> Reviews { get; set; }
        public double Rating { get; set; }
        public int NumReviews { get; set; }
        public int Price { get; set; }
        public int CountInStock { get; set; }
    }
}
