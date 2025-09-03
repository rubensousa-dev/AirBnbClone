using DevBnbStart.Application.Models;
using DevBnbStart.Core.Entities;
using DevBnbStart.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DevBnbStart.API.Controllers
{
    [ApiController]
    [Route("api/properties/{idProperty}/accommodations")]
    [Route("api/accommodations")]
    public class AccommodationsController : ControllerBase
    {
        readonly AppDbContext _context;
        public AccommodationsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll(Guid idProperty)
        {
            var accommodations = _context.Accomodations.Where
                (a => a.IdProperty == idProperty).ToList();

            return Ok(accommodations);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid idProperty, Guid id)
        {
            var accommodation = _context.Accomodations.SingleOrDefault
                (a => a.IdProperty == idProperty && a.Id == id);

            if (accommodation is null)
                return NotFound();

            return Ok(accommodation);
        }

        [HttpPost]
        public IActionResult Post(Guid idProperty, Accomodation accomodation)
        {
            accomodation.IdProperty = idProperty;
            _context.Accomodations.Add(accomodation);
            _context.SaveChanges();

            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid idProperty, Guid id, AccommandationUpdateInputModel model)
        {
            var existingAccommodation = _context.Accomodations.SingleOrDefault(a => a.Id == id
            && a.IdProperty == idProperty);

            if (existingAccommodation is null)
                return NotFound();

            existingAccommodation.UpdateInfo(model.Name, model.Description,
                model.MaxGuests, model.PricePerNight);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid idProperty, Guid id)
        {
            var existingAccommodation = _context.Accomodations.SingleOrDefault(a => a.Id == id
          && a.IdProperty == idProperty);

            if (existingAccommodation is null)
                return NotFound();

            existingAccommodation.SetAsDeleted();
            _context.SaveChanges();
            return NoContent();
        }
    }
}
