using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopsRUs.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {


        private readonly ICreateInvoiceService _createInvoiceService;

        public InvoicesController(ICreateInvoiceService createInvoiceService)
        {
            _createInvoiceService = createInvoiceService;
        }

        [HttpGet("create")]
        public IActionResult CreateInvoice([FromBody] InvoiceRequestDto dto)
        {
            var discount = _createInvoiceService.OnProcess(dto);

            return Ok(discount);
        }
    }
}
