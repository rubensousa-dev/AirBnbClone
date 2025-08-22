using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevBnbStart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
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
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
}
