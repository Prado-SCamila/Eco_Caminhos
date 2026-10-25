using EcocaminhosApi.Models;
using EcocaminhosApi.DTOs;



namespace EcocaminhosApi.Interfaces
{
    public interface IVoluntarioRepository
    {
        List<AlocacaoVoluntarioDto> ListarAlocacoes();
        List<Voluntario> ListarTodos();
        Voluntario? BuscarPorId(int id);
        void Cadastrar(Voluntario novoVoluntario);
        void Atualizar(int id, Voluntario voluntarioAtualizado);
        void Deletar(int id);
    }
}