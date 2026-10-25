using EcocaminhosApi.Data;
using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Repositories
{
    public class VoluntarioRepository : IVoluntarioRepository
    {
        // o contexto que acessa o banco, recebido pelo construtor
        private readonly AppDbContext _context;

        public VoluntarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Voluntario> ListarTodos()
        {
            // AsNoTracking: só leitura, mais rápido
            return _context.Voluntarios.AsNoTracking().ToList();
        }

        public Voluntario? BuscarPorId(int id)
        {
            return _context.Voluntarios.Find(id);
        }

        public void Cadastrar(Voluntario novoVoluntario)
        {
            _context.Voluntarios.Add(novoVoluntario);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Voluntario voluntarioAtualizado)
        {
            Voluntario? voluntarioBuscado = _context.Voluntarios.Find(id);

            if (voluntarioBuscado != null)
            {
                voluntarioAtualizado.IdVoluntario = id; // garante que a chave não muda
                _context.Entry(voluntarioBuscado).CurrentValues.SetValues(voluntarioBuscado);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            Voluntario? voluntarioBuscado = _context.Voluntarios.Find(id);

            if (voluntarioBuscado != null)
            {
                _context.Voluntarios.Remove(voluntarioBuscado);
                _context.SaveChanges();
            }
        }
    }
}