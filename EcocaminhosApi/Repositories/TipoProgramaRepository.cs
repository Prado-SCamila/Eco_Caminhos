using EcocaminhosApi.Data;
using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcocaminhosApi.Repositories
{
    public class TipoProgramaRepository : ITipoProgramaRepository
    {
        private readonly AppDbContext _context;

        public TipoProgramaRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<TipoPrograma> ListarTodos()
        {
            return _context.TipoProgramas.AsNoTracking().ToList();
        }

        public TipoPrograma? BuscarPorId(int id)
        {
            return _context.TipoProgramas.Find(id);
        }
    }
}