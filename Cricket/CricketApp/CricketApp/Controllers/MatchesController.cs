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
    public class MatchesController : ControllerBase
    {
        // GET: api/Country
        private readonly CricketContext _cricketcontext;
        public MatchesController(CricketContext cricket)
        {
            _cricketcontext = cricket;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getTheMatches = _cricketcontext.Matches.ToList();
            return Ok(getTheMatches);
        }

        /*
        // GET: api/Matches/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Matches
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Matches/5
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
