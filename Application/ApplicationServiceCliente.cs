using RestApiProject.Application.Dtos;
using RestApiProject.Application.Interfaces;
using RestApiProject.Application.Mapper.Interfaces;
using RestApiProject.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServicoCliente _servico;
        private readonly IMapperCliente _mapper;

        public ApplicationServiceCliente(
            IServicoCliente servico, 
            IMapperCliente mapper
        )
        {
            _servico = servico;
            _mapper = mapper;
        }

        public async Task AtualizarAsync(ClienteDto clienteDto)
        {
            var cliente = _mapper.MapearDtoParaEntidade(clienteDto);
            await _servico.AtualizarAsync(cliente);
        }

        public async Task InserirAsync(ClienteDto clienteDto)
        {
            var cliente = _mapper.MapearDtoParaEntidade(clienteDto);
            await _servico.InserirAsync(cliente);
        }

        public async Task<ClienteDto> ObterPorIdAsync(int id)
        {
            var cliente = await _servico.ObterPorIdAsync(id);
            return _mapper.MapearEntidadeParaDto(cliente);
        }

        public async Task<IEnumerable<ClienteDto>> ObterTodosAsync()
        {
            var clientes = await _servico.ObterTodosAsync();
            return _mapper.MapearListaClientesDto(clientes);
        }

        public async Task RemoverAsync(ClienteDto clienteDto)
        {
            var cliente = _mapper.MapearDtoParaEntidade(clienteDto);
            await _servico.RemoverAsync(cliente);
        }
    }
}
