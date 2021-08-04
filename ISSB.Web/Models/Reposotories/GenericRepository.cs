using ISSB.Web.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSB.Web.Models.Reposotories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        IQueryable<T> IGenericRepository<T>.GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        Task<T> IGenericRepository<T>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<T>.CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<T>.UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<T>.DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<T>.ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
