﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repsitories
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEnity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id ).ToList();
        }
        public void Add(T item)
        {
            _dbSet.Add(item);

        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

       
    }


}
