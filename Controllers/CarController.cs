using Microsoft.AspNetCore.Mvc;
using WebApplication1.Selectors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarSelector _carSelector;

        public CarController(ICarSelector carSelector)
        {
            _carSelector = carSelector;
        }

        [HttpGet("GetCarsByColor")]
        public IActionResult GetCar(string color)
        {
            var cars = _carSelector.GetCarByColor(color);
            return Ok(cars);
        }
        [HttpPost("SwitchHeadLights")]
        public IActionResult SwitchHeadLights(int id)
        {
            _carSelector.SwitchHeadLights(id);
            return Ok();
        }
        [HttpDelete("DeleteCar")]
        public IActionResult DeleteCar(int id)
        {
            _carSelector.DeleteCar(id);
            return Ok();
        }
    }
}
