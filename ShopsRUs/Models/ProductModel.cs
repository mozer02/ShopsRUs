using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public class ProductModel
    {
        public string ProductName { get; private set; }
        public string Barcode { get;private set; }
        public string ProductType { get;private set; }
        public int ProductPrice { get;private set; }
        public string Description { get; set; } 

    }
}
