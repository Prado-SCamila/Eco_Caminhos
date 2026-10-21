using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcocaminhosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CasasController : ControllerBase
    {
        // objeto que vai receber os métodos do repository
        private readonly ICasaRepository _casaRepository;

        // construtor: o ASP.NET entrega o repository já criado
        public CasasController(ICasaRepository casaRepository)
        {
            _casaRepository = casaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Casa> listaCasas = _casaRepository.ListarTodos();
            return Ok(listaCasas); // 200
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Casa? casaBuscada = _casaRepository.BuscarPorId(id);

            if (casaBuscada == null)
            {
                return NotFound("Nenhuma casa foi encontrada");
            }
            return Ok(casaBuscada);
        }

        [HttpPost]
        public IActionResult Post(Casa novaCasa)
        {
            _casaRepository.Cadastrar(novaCasa);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Casa casaAtualizada)
        {
            _casaRepository.Atualizar(id, casaAtualizada);
            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _casaRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}