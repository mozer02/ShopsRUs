using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Application
{
    /// <summary>
    /// Fatura oluşturmak için kullanılan kullanıcıdan kimlik bilgisi ve ürün isteyen, sonucunda indirimli toplam fiyatı yollayan servis  
    /// </summary>
    public interface ICreateInvoiceService : IApplicationService<InvoiceRequestDto, decimal>
    {
    }
}
