using System;
using System.Collections.Generic;
using System.Text;

namespace Globals.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> List();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
