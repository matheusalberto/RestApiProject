using RestApiProject.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        Task InserirAsync(ClienteDto clienteDto);
        Task AtualizarAsync(ClienteDto clienteDto);
        Task RemoverAsync(ClienteDto clienteDto);
        Task<IEnumerable<ClienteDto>> ObterTodosAsync();
        Task<ClienteDto> ObterPorIdAsync(int id);
    }
}
