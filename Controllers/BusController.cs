using Microsoft.AspNetCore.Mvc;
using WebApplication1.Selectors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {

        private readonly IBusSelector _busSelector;

        public BusController(IBusSelector busSelector)
        {
            _busSelector = busSelector;
        }

        [HttpGet("GetBusByColor")]
        public IActionResult GetBus(string color)
        {
            var buses = _busSelector.GetBusByColor(color);
            return Ok(buses);
        }


        // GET: api/<BusController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BusController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
