using Microsoft.AspNetCore.Mvc;
using Payment_API.Business;
using Payment_API.Model;
using System.Collections.Generic;

namespace Payment_API.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [ApiController]
    public class PaymentsDataController : ControllerBase
    {
        
        private IPaymentsData _paymentsData;

        public PaymentsDataController(IPaymentsData paymentsData)
        {
            _paymentsData = paymentsData;
        }

        // GET api/v1/PaymentsData/Cartoes
        [HttpGet]
        public IActionResult FindAllCartoes()
        {
            return Ok(_paymentsData.FindAll());
        }
        
        // POST api/v1/PaymentsData
        [HttpPost]
        public string Post([FromBody] PaymentsData paymentsData)
        {
            return _paymentsData.Create(paymentsData);
        }

    }
}
