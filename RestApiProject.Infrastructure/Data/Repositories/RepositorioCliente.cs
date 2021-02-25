using RestApiProject.Domain.Core.Interfaces.Repositories;
using RestApiProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiProject.Infrastructure.Data.Repositories
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
    {
        private DatabaseContext _context { get; set; }

        public RepositorioCliente(DatabaseContext context) : base(context) 
        {
            this._context = context;
        }
    }
}
