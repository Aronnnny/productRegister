using productRegister.Domain.Repositories;
using productRegister.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productRegister.Infra.Repositories
{
    public class RepositoryBase<T>(DataContext context) : IRepositoryBase<T> where T : class
    {
        private readonly DataContext _context;
        public async Task<bool> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool?> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
