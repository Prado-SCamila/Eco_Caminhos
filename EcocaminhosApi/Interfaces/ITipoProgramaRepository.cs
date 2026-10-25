using EcocaminhosApi.Models;

namespace EcocaminhosApi.Interfaces
{
    public interface ITipoProgramaRepository
    {
        List<TipoPrograma> ListarTodos();
        TipoPrograma? BuscarPorId(int id);
    }
}