using RestApiProject.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Domain.Core.Interfaces.Services
{
    public interface IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        Task InserirAsync(TEntidade entidade);
        Task AtualizarAsync(TEntidade entidade);
        Task RemoverAsync(TEntidade entidade);
        Task<IEnumerable<TEntidade>> ObterTodosAsync();
        Task<TEntidade> ObterPorIdAsync(int id);
    }
}
