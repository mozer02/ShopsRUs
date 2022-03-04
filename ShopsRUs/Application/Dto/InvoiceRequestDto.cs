using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application.Dto
{
    public class InvoiceRequestDto
    {
        public int IdentityNumber { get; set; }
        public string TotalPrice { get; set; }
    }
}
