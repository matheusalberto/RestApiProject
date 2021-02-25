using RestApiProject.Domain.Core.Interfaces.Repositories;
using RestApiProject.Domain.Entities;

namespace RestApiProject.Infrastructure.Data.Repositories
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        private DatabaseContext _context { get; set; }

        public RepositorioProduto(DatabaseContext context) : base(context) 
        {
            this._context = context;
        }
    }
}
