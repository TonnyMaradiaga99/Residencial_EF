using System.Net;
using Microsoft.AspNetCore.Mvc;
using residencial.Models;

namespace residencial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class residenteController : ControllerBase
    {
        IresidenteService residenteService;
        public residenteController(IresidenteService _residenteService)
        {
            residenteService = _residenteService;
        }

        [HttpPost]
        public async Task<IActionResult> postresidente([FromBody] residente newresidente)
        {
            await residenteService.CreateAsync(newresidente);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(residenteService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] residente updresidente)
        {
            await residenteService.Update(id, updresidente);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await residenteService.Delete(id);
            return Ok();
        }
    }
}