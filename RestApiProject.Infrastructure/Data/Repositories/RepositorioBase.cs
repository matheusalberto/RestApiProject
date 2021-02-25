using Microsoft.EntityFrameworkCore;
using RestApiProject.Domain.Core.Interfaces.Repositories;
using RestApiProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiProject.Infrastructure.Data.Repositories
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase
    {
        private DatabaseContext _context { get; set; }

        public RepositorioBase(DatabaseContext context)
        {
            _context = context;
        }

        public async Task InserirAsync(TEntidade entidade)
        {
            try
            {
                _context.Set<TEntidade>().Add(entidade);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AtualizarAsync(TEntidade entidade)
        {
            try
            {
                _context.Entry(entidade).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task RemoverAsync(TEntidade entidade)
        {
            try
            {
                _context.Set<TEntidade>().Remove(entidade);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntidade>> ObterTodosAsync()
            => await _context.Set<TEntidade>().ToListAsync();

        public async Task<TEntidade> ObterPorIdAsync(int id)
            => await _context.Set<TEntidade>().FirstOrDefaultAsync(x => x.Id == id);
    }
}
