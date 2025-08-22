using Microsoft.AspNetCore.Mvc;

namespace DevBnbStart.API.Controllers
{
    [ApiController]
    [Route("api/properties")]
    public class PropertiesController : ControllerBase
    {
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
        public IActionResult Post()
        {
            return Ok();
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
