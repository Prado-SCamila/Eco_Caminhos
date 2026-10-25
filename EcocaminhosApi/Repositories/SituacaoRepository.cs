using EcocaminhosApi.Data;
using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {
        private readonly AppDbContext _context;

        public SituacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Situacao> ListarTodos()
        {
            return _context.Situacaos.AsNoTracking().ToList();
        }

        public Situacao? BuscarPorId(int id)
        {
            return _context.Situacaos.Find(id);
        }
    }
}