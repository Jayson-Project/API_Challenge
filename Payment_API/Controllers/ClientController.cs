using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Payment_API.Business;
using Payment_API.Model;

namespace Payment_API.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private IClient _clientService;

        public ClientController(IClient clientService)
        {
            _clientService = clientService;
        }

        // GET api/v1/Client
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientService.FindAll());
        }

        // GET api/v1/Client/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Client client = _clientService.FindById(id);
            if (client == null)
                return NotFound();
            return Ok(client);
        }

        // POST api/v1/Client
        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            if (client == null) return BadRequest();
            return Ok(_clientService.Create(client));
        }

        // PUT api/v1/Client/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Client client)
        {
            if (client == null) return BadRequest();
            var alteraItem = _clientService.Update(client);
            if (client == null) return NoContent();
            return new ObjectResult(alteraItem);
        }

        // DELETE api/v1/Client/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest();
            _clientService.Delete(id);

            //NoContent qdo não retorna nada (204 na tela)
            return NoContent();
        }
    }
}
