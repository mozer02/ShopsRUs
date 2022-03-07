using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopsRUs.Application;

namespace ShopsRUs_UnitTest
{
    [TestClass]
    public class UnitTest
    {        
        [TestMethod]
        public void InvoiceUnitTest()
        {
            CreateInvoiceService createInvoiceService = new CreateInvoiceService();
            InvoiceRequestDto dto = new InvoiceRequestDto();
            dto.IdentityNumber = 7654321;
            dto.Products.Add(new ProductDto() { Barcode = "1231231", Quantity = 1 });
            dto.Products.Add(new ProductDto() { Barcode = "12141245", Quantity = 1 });
            dto.Products.Add(new ProductDto() { Barcode = "12312334", Quantity = 2 });
            var discount = createInvoiceService.OnProcess(dto);
            Assert.AreEqual(discount, 172);
        }

    }
}
