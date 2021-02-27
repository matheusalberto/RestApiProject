using RestApiProject.Application.Dtos;
using RestApiProject.Domain.Entities;
using System.Collections.Generic;

namespace RestApiProject.Application.Mapper.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapearDtoParaEntidade(ClienteDto clienteDto);
        ClienteDto MapearEntidadeParaDto(Cliente cliente);
        IEnumerable<ClienteDto> MapearListaClientesDto(IEnumerable<Cliente> clientes);
    }
}
