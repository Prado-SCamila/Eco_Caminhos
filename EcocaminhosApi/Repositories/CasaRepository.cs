using EcocaminhosApi.Data;
using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Repositories
{
    public class CasaRepository : ICasaRepository
    {
        // o contexto que acessa o banco, recebido pelo construtor
        private readonly AppDbContext _context;

        public CasaRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Casa> ListarTodos()
        {
            // AsNoTracking: só leitura, mais rápido
            return _context.Casas.AsNoTracking().ToList();
        }

        public Casa? BuscarPorId(int id)
        {
            return _context.Casas.Find(id);
        }

        public void Cadastrar(Casa novaCasa)
        {
            _context.Casas.Add(novaCasa);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Casa casaAtualizada)
        {
            Casa? casaBuscada = _context.Casas.Find(id);

            if (casaBuscada != null)
            {
                casaAtualizada.IdCasa = id; // garante que a chave não muda
                _context.Entry(casaBuscada).CurrentValues.SetValues(casaAtualizada);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            Casa? casaBuscada = _context.Casas.Find(id);

            if (casaBuscada != null)
            {
                _context.Casas.Remove(casaBuscada);
                _context.SaveChanges();
            }
        }
    }
}