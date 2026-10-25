using EcocaminhosApi.Models;
using EcocaminhosApi.DTOs;


namespace EcocaminhosApi.Interfaces
{
    public interface IQuartoRepository
    {
        List<QuartoDisponivelDto> ListarDisponiveis(string? nomeCasa = null);
        List<Quarto> ListarTodos();
        Quarto? BuscarPorId(int id);
        void Cadastrar(Quarto novoQuarto);
        void Atualizar(int id, Quarto quartoAtualizado);
        void Deletar(int id);
    }
}