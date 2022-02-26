using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    public class PaymentResult
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string UpdateTime { get; set; }
        public string EmailAddress { get; set; }
    }
}
