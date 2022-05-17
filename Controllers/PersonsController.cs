using Microsoft.AspNetCore.Mvc;
using Timesheets.DAL.Repositories;
using Timesheets.Models;
using System;
using System.Linq;
using System.Collections.Generic;

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
            var rez = _repository.GetAll().ToList();
            var r = rez.Find(x => x.FirstName == name);
            return Ok(r);
        }

        [HttpGet("persons/skip/{fromid}take/{toid}")]
        public IActionResult GetByName([FromRoute] int fromid, [FromRoute] int toid)
        {
            var rez = _repository.GetAll().ToList();
            var r = rez.FindAll(x => x.Id >= fromid && x.Id <= toid);
            return Ok(r);
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpDelete("persons/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}