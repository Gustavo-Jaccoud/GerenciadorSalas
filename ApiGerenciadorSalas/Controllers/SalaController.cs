using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Entities.Responses;
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

        [HttpPost]
        public async Task<ActionResult<ResponseModel<Sala>>> Create(SalaCriacaoDto salaCriacaoDto)
        {
            var sala = await _salaService.Create(salaCriacaoDto);
            return Ok(sala);
        }

        [HttpGet("{idSala}")]
        public async Task<ActionResult<ResponseModel<Sala>>> GetById(int idSala)
        {
            var sala = await _salaService.GetById(idSala);
            return Ok(sala);
        }
        
    }
}