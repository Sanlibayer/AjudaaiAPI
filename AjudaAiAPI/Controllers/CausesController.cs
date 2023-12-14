using AjudaAiAPI.Contracts.Repository;
using AjudaAiAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AjudaAiAPI.Controllers
{
    [ApiController]
    [Route("causes")]
    public class CausesController : ControllerBase
    {
        private readonly ICausesRepository _causesRepository;
        public CausesController(ICausesRepository causesRepository)
        {
            _causesRepository = causesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _causesRepository.Get());
        }
    }
}
