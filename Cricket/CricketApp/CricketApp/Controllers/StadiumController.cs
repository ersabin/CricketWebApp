using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CricketApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CricketApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        // GET: api/Stadium
        // GET: api/Country
        private readonly CricketContext _cricketcontext;
        public StadiumController(CricketContext cricket)
        {
            _cricketcontext = cricket;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getTheStadium = _cricketcontext.Stadium.ToList();
            return Ok(getTheStadium);
        }

        /*
        // GET: api/Stadium/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stadium
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stadium/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
