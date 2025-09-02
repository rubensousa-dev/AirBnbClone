using DevBnbStart.Core.Entities;
using DevBnbStart.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DevBnbStart.API.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        readonly AppDbContext _context;

        int counter = 1;
        public ClientsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (client == null)
                return NotFound();
            return Ok(client);
        }

        [HttpPost]
        public IActionResult Post(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new {id = client.Id},client);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Client client)
        {
            var existingClient = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (existingClient is null)
                return NotFound();

            existingClient.Update(client.Observations, client.FullName, client.PhoneNumber, client.Address);
            _context.SaveChanges();


            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
}
