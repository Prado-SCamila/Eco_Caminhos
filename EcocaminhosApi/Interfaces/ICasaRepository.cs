using EcocaminhosApi.Models;

namespace EcocaminhosApi.Interfaces
{
    public interface ICasaRepository
    {
        List<Casa> ListarTodos();
        Casa? BuscarPorId(int id);
        void Cadastrar(Casa novaCasa);
        void Atualizar(int id, Casa casaAtualizada);
        void Deletar(int id);
    }
}