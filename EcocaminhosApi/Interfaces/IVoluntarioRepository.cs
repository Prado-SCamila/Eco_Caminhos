using EcocaminhosApi.Models;

namespace EcocaminhosApi.Interfaces
{
    public interface IVoluntarioRepository
    {
        List<Voluntario> ListarTodos();
        Voluntario? BuscarPorId(int id);
        void Cadastrar(Voluntario novoVoluntario);
        void Atualizar(int id, Voluntario voluntarioAtualizado);
        void Deletar(int id);
    }
}