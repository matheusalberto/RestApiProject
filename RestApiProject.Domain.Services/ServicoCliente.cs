using RestApiProject.Domain.Core.Interfaces.Repositories;
using RestApiProject.Domain.Core.Interfaces.Services;
using RestApiProject.Domain.Entities;

namespace RestApiProject.Domain.Services
{
    public class ServicoCliente : ServicoBase<Cliente>, IServicoCliente
    {
        private readonly IRepositorioCliente _repositorio;

        public ServicoCliente(IRepositorioCliente repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
