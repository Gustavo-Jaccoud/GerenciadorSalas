using ApiGerenciadorSalas.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiGerenciadorSalas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalaController : ControllerBase
    {
        private readonly ISalaService _salaService;

        public SalaController(ISalaService salaService)
        {
            _salaService = salaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var salas = await _salaService.GetAll();
            return Ok(salas);
        }
    }
}