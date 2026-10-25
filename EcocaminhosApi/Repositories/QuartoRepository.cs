using EcocaminhosApi.Data;
using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Models;
using Microsoft.EntityFrameworkCore;
using EcocaminhosApi.DTOs;


namespace EcocaminhosApi.Repositories
{
    public class QuartoRepository : IQuartoRepository
    {
        // o contexto que acessa o banco, recebido pelo construtor
        private readonly AppDbContext _context;

        public QuartoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Quarto> ListarTodos()
        {
            // AsNoTracking: só leitura, mais rápido
            return _context.Quartos.AsNoTracking().ToList();
        }

        public Quarto? BuscarPorId(int id)
        {
            return _context.Quartos.Find(id);
        }

        public void Cadastrar(Quarto novoQuarto)
        {
            _context.Quartos.Add(novoQuarto);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Quarto quartoAtualizado)
        {
            Quarto? quartoBuscado = _context.Quartos.Find(id);

            if (quartoBuscado != null)
            {
                quartoAtualizado.IdQuarto = id; // garante que a chave não muda
                _context.Entry(quartoBuscado).CurrentValues.SetValues(quartoAtualizado);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            Quarto? quartoBuscado = _context.Quartos.Find(id);

            if (quartoBuscado != null)
            {
                _context.Quartos.Remove(quartoBuscado);
                _context.SaveChanges();
            }
        }
        public List<QuartoDisponivelDto> ListarDisponiveis(string? nomeCasa = null)
{
    var query = _context.Quartos
        .AsNoTracking()
        .Select(q => new QuartoDisponivelDto
        {
            NomeCasa = q.IdCasaNavigation.NomeCasa,
            NomeQuarto = q.NomeQuarto,
            Capacidade = q.Capacidade,
            TotalVoluntarios = q.Voluntarios.Count(),
            VagasDisponiveis = q.Capacidade - q.Voluntarios.Count()
        })
        .Where(d => d.VagasDisponiveis > 0);

    if (!string.IsNullOrWhiteSpace(nomeCasa))
        query = query.Where(d => d.NomeCasa == nomeCasa);

    return query.OrderBy(d => d.NomeCasa).ThenBy(d => d.NomeQuarto).ToList();
}

    }
}