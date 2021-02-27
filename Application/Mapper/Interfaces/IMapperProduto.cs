using RestApiProject.Application.Dtos;
using RestApiProject.Domain.Entities;
using System.Collections.Generic;

namespace RestApiProject.Application.Mapper.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapearDtoParaEntidade(ProdutoDto produtoDto);
        ProdutoDto MapearEntidadeParaDto(Produto produto);
        IEnumerable<ProdutoDto> MapearListaProdutosDto(IEnumerable<Produto> produtos);
    }
}
