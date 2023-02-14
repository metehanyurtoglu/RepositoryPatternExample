using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Interfaces;
using Service.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [Route("[action]/{Id}")]
        [HttpGet]
        public IActionResult GetCity(long Id)
        {
            CountryDTO countryDTO = _countryService.GetById(Id);

            return Ok(countryDTO);
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult AddCity(CountryDTO countryDTO)
        {
            _countryService.Add(countryDTO);

            return Ok();
        }

        [Route("[action]")]
        [HttpDelete]
        public IActionResult RemoveCity(CountryDTO countryDTO)
        {
            _countryService.Remove(countryDTO);

            return Ok();
        }
    }
}
