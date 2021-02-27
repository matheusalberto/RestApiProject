using Microsoft.EntityFrameworkCore;
using RestApiProject.Domain.Entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestApiProject.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entradas = ChangeTracker
                .Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null);

            foreach (var entrada in entradas)
            {
                if (entrada.State == EntityState.Added)
                {
                    entrada.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entrada.State == EntityState.Modified)
                {
                    entrada.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
