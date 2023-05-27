using System.Net;
using Microsoft.AspNetCore.Mvc;
using residencial.Models;

namespace residencial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class casaController : ControllerBase
    {
        IcasaService casaService;
        public casaController(IcasaService _casaService)
        {
            casaService = _casaService;
        }

        [HttpPost]
        public async Task<IActionResult> postcasa([FromBody] casa newcasa)
        {
            await casaService.CreateAsync(newcasa);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(casaService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] casa updcasa)
        {
            await casaService.Update(id, updcasa);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await casaService.Delete(id);
            return Ok();
        }
    }
}