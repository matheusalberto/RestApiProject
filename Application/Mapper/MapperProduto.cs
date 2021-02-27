using RestApiProject.Application.Dtos;
using RestApiProject.Application.Mapper.Interfaces;
using RestApiProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiProject.Application.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapearDtoParaEntidade(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public ProdutoDto MapearEntidadeParaDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapearListaProdutosDto(IEnumerable<Produto> produtos)
            => produtos.Select(MapearEntidadeParaDto);
    }
}
