using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleService.Models;

namespace PeopleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleProvider peopleProvider;

        public PeopleController(IPeopleProvider peopleProvider)
        {
            this.peopleProvider = peopleProvider;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return peopleProvider.GetPeople();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return peopleProvider.GetPeople().FirstOrDefault(p => p.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
