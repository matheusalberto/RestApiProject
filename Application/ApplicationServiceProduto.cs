using RestApiProject.Application.Dtos;
using RestApiProject.Application.Interfaces;
using RestApiProject.Application.Mapper.Interfaces;
using RestApiProject.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServicoProduto _servico;
        private readonly IMapperProduto _mapper;

        public ApplicationServiceProduto(
            IServicoProduto servico,
            IMapperProduto mapper
        )
        {
            _servico = servico;
            _mapper = mapper;
        }

        public async Task AtualizarAsync(ProdutoDto clienteDto)
        {
            var produto = _mapper.MapearDtoParaEntidade(clienteDto);
            await _servico.AtualizarAsync(produto);
        }

        public async Task InserirAsync(ProdutoDto clienteDto)
        {
            var produto = _mapper.MapearDtoParaEntidade(clienteDto);
            await _servico.InserirAsync(produto);
        }

        public async Task<ProdutoDto> ObterPorIdAsync(int id)
        {
            var produto = await _servico.ObterPorIdAsync(id);
            return _mapper.MapearEntidadeParaDto(produto);
        }

        public async Task<IEnumerable<ProdutoDto>> ObterTodosAsync()
        {
            var clientes = await _servico.ObterTodosAsync();
            return _mapper.MapearListaProdutosDto(clientes);
        }

        public async Task RemoverAsync(ProdutoDto clienteDto)
        {
            var produto = _mapper.MapearDtoParaEntidade(clienteDto);
            await _servico.RemoverAsync(produto);
        }
    }
}
