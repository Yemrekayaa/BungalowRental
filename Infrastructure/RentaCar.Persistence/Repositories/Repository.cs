using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentaCar.Application.Interfaces;
using RentaCar.Persistence.Context;

namespace RentaCar.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RentaCarContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(RentaCarContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public async Task CreateAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
           _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}