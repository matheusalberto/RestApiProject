using RestApiProject.Domain.Core.Interfaces.Repositories;
using RestApiProject.Domain.Core.Interfaces.Services;
using RestApiProject.Domain.Entities;

namespace RestApiProject.Domain.Services
{
    public class ServicoProduto : ServicoBase<Produto>, IServicoProduto
    {
        private readonly IRepositorioProduto _repositorio;

        public ServicoProduto(IRepositorioProduto repositorio) : base (repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
