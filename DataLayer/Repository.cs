using System;
using System.Collections.Generic;
using System.Text;
using Globals.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace DataLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SprongContext _dbContext;

        public Repository(SprongContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> List()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

    }
}
