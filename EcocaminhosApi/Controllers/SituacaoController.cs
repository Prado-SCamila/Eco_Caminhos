using EcocaminhosApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcocaminhosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SituacaoController : ControllerBase
    {
        private readonly ISituacaoRepository _situacaoRepository;

        public SituacaoController(ISituacaoRepository situacaoRepository)
        {
            _situacaoRepository = situacaoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_situacaoRepository.ListarTodos());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var situacao = _situacaoRepository.BuscarPorId(id);

            if (situacao == null)
            {
                return NotFound("Nenhuma situação foi encontrada");
            }
            return Ok(situacao);
        }
    }
}