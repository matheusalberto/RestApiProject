using RestApiProject.Application.Dtos;
using RestApiProject.Application.Mapper.Interfaces;
using RestApiProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiProject.Application.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapearDtoParaEntidade(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            };

            return cliente;
        }

        public ClienteDto MapearEntidadeParaDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapearListaClientesDto(IEnumerable<Cliente> clientes)
            => clientes.Select(MapearEntidadeParaDto);
    }
}
