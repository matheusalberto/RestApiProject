using RestApiProject.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Domain.Core.Interfaces.Repositories
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase
    {
        Task InserirAsync(TEntidade entidade);
        Task AtualizarAsync(TEntidade entidade);
        Task RemoverAsync(TEntidade entidade);
        Task<IEnumerable<TEntidade>> ObterTodosAsync();
        Task<TEntidade> ObterPorIdAsync(int id);
    }
}
