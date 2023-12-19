using AjudaAiAPI.Contracts.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AjudaAiAPI.Controllers
{
    [ApiController]
    [Route("causes")]
    public class CausesController : ControllerBase
    {
        private readonly IStateRepository _causesRepository;

        public CausesController(IStateRepository causesRepository)
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
