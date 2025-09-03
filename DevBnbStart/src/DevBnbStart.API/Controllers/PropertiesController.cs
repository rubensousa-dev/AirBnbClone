using DevBnbStart.Application.Models;
using DevBnbStart.Core.Entities;
using DevBnbStart.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DevBnbStart.API.Controllers
{
    [ApiController]
    [Route("api/properties")]
    public class PropertiesController : ControllerBase
    {
        readonly AppDbContext _context;
        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(AddPropertyInputModel model)
        {
            var property = new Property(
                model.Title,
                model.Description,
                model.Address,
                model.IdHost,
                model.CancellationPolicy
            );
            _context.Properties.Add(property);
            _context.SaveChanges();

            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id)
        {
            return Ok();
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete(Guid id)
        {
            return NoContent();
        }
    }
}
