using Microsoft.AspNetCore.Mvc;
using Timesheets.DAL.Repositories;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsRepository _repository;

        public PersonsController(IPersonsRepository repository)
        { 
            _repository = repository;
        }

        [HttpGet("/persons/{id}")]
        public IActionResult GetByID([FromRoute] int id)
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("persons/searchTerm={term}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            return Ok();
        }

        [HttpGet("persons/skip/{fromid}take/{toid}")]
        public IActionResult GetByName([FromRoute] int fromid, [FromRoute] int toid)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpDelete("persons/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}