using AjudaAiAPI.Contracts.Repository;
using AjudaAiAPI.DTO;
using AjudaAiAPI.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AjudaAiAPI.Controllers
{
    [ApiController]
    [Route("ngo")]
    public class NgoController : ControllerBase
    {
        private readonly INgoRepository _ngoRepository;
        public NgoController(INgoRepository ngoRepository)
        {
            _ngoRepository = ngoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _ngoRepository.Get());
        }

        [HttpPost]
        public async Task<IActionResult> Add(NgoDTO ngo)
        {
            await _ngoRepository.Add(ngo);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(NgoEntity ngo)
        {
            await _ngoRepository.Update(ngo);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _ngoRepository.Delete(id);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ngoRepository.GetById(id));
        }
    }
}
