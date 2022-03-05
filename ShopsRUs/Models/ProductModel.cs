using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public class ProductModel
    {
        public string ProductName { get;  set; }
        public string Barcode { get; set; }
        public string ProductType { get; set; }
        public int ProductPrice { get; set; }
        public string Description { get; set; } 
    }
}
