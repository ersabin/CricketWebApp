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
    public class PlayersController : ControllerBase
    {
        // GET: api/Country
        private readonly CricketContext _Playerscontext;
        public PlayersController(CricketContext cricket)
        {
            _Playerscontext = cricket;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getThePlayers = _Playerscontext.Players.ToList();
            return Ok(getThePlayers);
        }

        /*
        // GET: api/Players/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Players
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Players/5
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
