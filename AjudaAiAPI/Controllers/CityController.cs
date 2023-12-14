using AjudaAiAPI.Contracts.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AjudaAiAPI.Controllers
{
    [ApiController]
    [Route("city")]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _cityRepository.Get());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByState(int id)
        {
            return Ok(await _cityRepository.GetByState(id));
        }

    }
}
