using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.AspNetCore.Mvc;
using EcocaminhosApi.DTOs;


namespace EcocaminhosApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    
    [ApiController]
    public class VoluntarioController : ControllerBase
    {
        // objeto que vai receber os métodos do repository
        private readonly IVoluntarioRepository _voluntarioRepository;

        // construtor: o ASP.NET entrega o repository já criado
        public VoluntarioController(IVoluntarioRepository voluntarioRepository)
        {
            _voluntarioRepository = voluntarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Voluntario> listaVoluntarios = _voluntarioRepository.ListarTodos();
            return Ok(listaVoluntarios); // 200
        }

        [HttpGet("alocacoes")]
        public IActionResult GetAlocacoes()
        {
         return Ok(_voluntarioRepository.ListarAlocacoes());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Voluntario? voluntarioBuscado = _voluntarioRepository.BuscarPorId(id);

            if (voluntarioBuscado == null)
            {
                return NotFound("Nenhum voluntário foi encontrado");
            }
            return Ok(voluntarioBuscado);
        }

        [HttpPost]
        public IActionResult Post(Voluntario novoVoluntario)
        {
            _voluntarioRepository.Cadastrar(novoVoluntario);
            return StatusCode(201);
        }

       [HttpPut("{id}")]
public IActionResult Put(int id, Voluntario voluntarioAtualizado)
{
    _voluntarioRepository.Atualizar(id, voluntarioAtualizado);
    return StatusCode(204);
}

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _voluntarioRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}