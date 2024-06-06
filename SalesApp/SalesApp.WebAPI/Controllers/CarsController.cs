using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SalesApp.Domain.Entities;
using SalesApp.Domain.Services;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        CarService carService = new CarService();

        [HttpPost]
        public ActionResult Post([FromBody] Car car)
        {
            car.Id = Guid.NewGuid();
            carService.Add(car);
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult PrintToConsole()
        {
            carService.PrintConsole();
            return Ok();

        }
        
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            List<Car> cars = carService.GetAll();
            return Ok(cars);
        }

        [HttpDelete("action")]
        public ActionResult Remove(Guid id)
        {
            carService.Remove(id);

            return Ok();
        }

        [HttpPost("action")]
        public IActionResult Update(Guid Id, string Make, int Year)
        {
            carService.Update(Id, Make, Year);

            return Ok();
        }

    }
}
