using DevBnbStart.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Entities = DevBnbStart.Core.Entities;
namespace DevBnbStart.API.Controllers
{
    [Route("api/hosts")]
    [ApiController]
    public class HostsController : ControllerBase
    {
        readonly AppDbContext _context;
        public HostsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Entities.Host host)
        {
            _context.Hosts.Add(host);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
}
