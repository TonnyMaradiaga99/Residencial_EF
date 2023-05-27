using System.Net;
using Microsoft.AspNetCore.Mvc;
using residencial.Models;

namespace residencial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class visitanteController : ControllerBase
    {
        IvisitanteService visitanteService;
        public visitanteController(IvisitanteService _visitanteService)
        {
            visitanteService = _visitanteService;
        }

        [HttpPost]
        public async Task<IActionResult> postvisitante([FromBody] visitante newvisitante)
        {
            await visitanteService.CreateAsync(newvisitante);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(visitanteService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] visitante updvisitante)
        {
            await visitanteService.Update(id, updvisitante);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await visitanteService.Delete(id);
            return Ok();
        }
    }
}