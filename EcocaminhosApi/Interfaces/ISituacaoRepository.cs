using EcocaminhosApi.Models;

namespace EcocaminhosApi.Interfaces
{
    public interface ISituacaoRepository
    {
        List<Situacao> ListarTodos();
        Situacao? BuscarPorId(int id);
    }
}