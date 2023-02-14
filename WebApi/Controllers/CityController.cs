using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [Route("[action]/{Id}")]
        [HttpGet]
        public IActionResult GetCity(long Id)
        {
            CityDTO cityDTO = _cityService.GetById(Id);

            return Ok(cityDTO);
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult AddCity(CityDTO cityDTO)
        {
            _cityService.Add(cityDTO);

            return Ok();
        }

        [Route("[action]")]
        [HttpDelete]
        public IActionResult RemoveCity(CityDTO cityDTO)
        {
            _cityService.Remove(cityDTO);

            return Ok();
        }
    }
}
