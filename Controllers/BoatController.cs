using Microsoft.AspNetCore.Mvc;
using WebApplication1.Selectors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatSelector _boatSelector;

        public BoatController(IBoatSelector boatSelector)
        {
            _boatSelector = boatSelector;
        }

        [HttpGet("GetBoatByColor")]
        public IActionResult GetBoat(string color)
        {
            var boats = _boatSelector.GetBoatByColor(color);
            return Ok(boats);
        }



        // GET: api/<BoatController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BoatController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BoatController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BoatController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BoatController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
