using RestApiProject.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        Task InserirAsync(ProdutoDto produtoDto);
        Task AtualizarAsync(ProdutoDto produtoDto);
        Task RemoverAsync(ProdutoDto produtoDto);
        Task<IEnumerable<ProdutoDto>> ObterTodosAsync();
        Task<ProdutoDto> ObterPorIdAsync(int id);
    }
}
