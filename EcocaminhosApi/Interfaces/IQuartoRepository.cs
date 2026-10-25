using EcocaminhosApi.Models;

namespace EcocaminhosApi.Interfaces
{
    public interface IQuartoRepository
    {
        List<Quarto> ListarTodos();
        Quarto? BuscarPorId(int id);
        void Cadastrar(Quarto novoQuarto);
        void Atualizar(int id, Quarto quartoAtualizado);
        void Deletar(int id);
    }
}