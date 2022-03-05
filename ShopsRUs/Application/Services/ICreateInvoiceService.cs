using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application
{
    public interface ICreateInvoiceService : IApplicationService<InvoiceRequestDto, decimal>
    {
    }
}
