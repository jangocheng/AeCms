﻿using Ator.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ator.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly AeDbContext _context = null;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase(AeDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public long Count()
        {
            return _dbSet.LongCount();
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }
        public IQueryable<T> GetAllList(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return _dbSet;
            }
            return _dbSet.Where(predicate);
        }
        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
