﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMongoApi.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid ParentId { get; set; }
    }
}
