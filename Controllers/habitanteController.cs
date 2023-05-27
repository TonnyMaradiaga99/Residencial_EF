using System.Net;
using Microsoft.AspNetCore.Mvc;
using residencial.Models;

namespace residencial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class habitanteController : ControllerBase
    {
        IhabitanteService habitanteService;
        public habitanteController(IhabitanteService _habitanteService)
        {
            habitanteService = _habitanteService;
        }

        [HttpPost]
        public async Task<IActionResult> posthabitante([FromBody] habitante newhabitante)
        {
            await habitanteService.CreateAsync(newhabitante);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(habitanteService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] habitante updhabitante)
        {
            await habitanteService.Update(id, updhabitante);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await habitanteService.Delete(id);
            return Ok();
        }
    }
}