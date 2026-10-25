using EcocaminhosApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcocaminhosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    
    [ApiController]
    public class TipoProgramaController : ControllerBase
    {
        private readonly ITipoProgramaRepository _tipoProgramaRepository;

        public TipoProgramaController(ITipoProgramaRepository tipoProgramaRepository)
        {
            _tipoProgramaRepository = tipoProgramaRepository;
        }

        // lista para o dropdown do front
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoProgramaRepository.ListarTodos());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tipoPrograma = _tipoProgramaRepository.BuscarPorId(id);

            if (tipoPrograma == null)
            {
                return NotFound("Nenhum tipo de programa foi encontrado");
            }
            return Ok(tipoPrograma);
        }
    }
}