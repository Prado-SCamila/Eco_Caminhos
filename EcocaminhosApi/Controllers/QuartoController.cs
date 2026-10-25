using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.AspNetCore.Mvc;
using EcocaminhosApi.DTOs;

namespace EcocaminhosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    [ApiController]
    public class QuartoController : ControllerBase
    {
        // objeto que vai receber os métodos do repository
        private readonly IQuartoRepository _quartoRepository;

        // construtor: o ASP.NET entrega o repository já criado
        public QuartoController(IQuartoRepository quartoRepository)
        {
            _quartoRepository = quartoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Quarto> listaQuartos = _quartoRepository.ListarTodos();
            return Ok(listaQuartos); // 200
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Quarto? quartoBuscado = _quartoRepository.BuscarPorId(id);

            if (quartoBuscado == null)
            {
                return NotFound("Nenhum quarto foi encontrado");
            }
            return Ok(quartoBuscado);
        }
        [HttpGet("disponiveis")]
         public IActionResult GetDisponiveis([FromQuery] string? nomeCasa)
        {
         return Ok(_quartoRepository.ListarDisponiveis(nomeCasa));
        }

        [HttpPost]
        public IActionResult Post(Quarto novoQuarto)
        {
            _quartoRepository.Cadastrar(novoQuarto);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Quarto quartoAtualizado)
        {
            _quartoRepository.Atualizar(id, quartoAtualizado);
            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _quartoRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}