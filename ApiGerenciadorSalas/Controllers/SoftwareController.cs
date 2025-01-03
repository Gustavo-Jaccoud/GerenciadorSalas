using ApiGerenciadorSalas.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiGerenciadorSalas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SoftwareController : ControllerBase
    {
        private readonly ISoftwareService _softwareService;

        public SoftwareController(ISoftwareService softwareService)
        {
            _softwareService = softwareService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var softwares = await _softwareService.GetAll();
            return Ok(softwares);
        }
    }
}