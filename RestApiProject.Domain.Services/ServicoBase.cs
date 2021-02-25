using RestApiProject.Domain.Core.Interfaces.Repositories;
using RestApiProject.Domain.Core.Interfaces.Services;
using RestApiProject.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Domain.Services
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        private readonly IRepositorioBase<TEntidade> _repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task AtualizarAsync(TEntidade entidade)
            => await _repositorio.AtualizarAsync(entidade);

        public async Task InserirAsync(TEntidade entidade)
            => await _repositorio.InserirAsync(entidade);

        public async Task<TEntidade> ObterPorIdAsync(int id)
            => await _repositorio.ObterPorIdAsync(id);

        public async Task<IEnumerable<TEntidade>> ObterTodosAsync()
            => await _repositorio.ObterTodosAsync();

        public async Task RemoverAsync(TEntidade entidade)
            => await _repositorio.RemoverAsync(entidade);
    }
}
