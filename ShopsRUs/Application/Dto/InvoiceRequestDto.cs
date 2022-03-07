using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application
{
    public class InvoiceRequestDto
    {
        public int IdentityNumber { get; set; }
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
