using System.Net;
using Microsoft.AspNetCore.Mvc;
using residencial.Models;

namespace residencial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class visitaController : ControllerBase
    {
        IvisitaService visitaService;
        public visitaController(IvisitaService _visitaService)
        {
            visitaService = _visitaService;
        }

        [HttpPost]
        public async Task<IActionResult> postvisita([FromBody] visita newvisita)
        {
            await visitaService.CreateAsync(newvisita);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(visitaService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] visita updvisita)
        {
            await visitaService.Update(id, updvisita);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await visitaService.Delete(id);
            return Ok();
        }
    }
}