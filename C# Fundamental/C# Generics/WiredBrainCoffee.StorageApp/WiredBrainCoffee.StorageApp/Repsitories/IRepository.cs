using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repsitories
{
    public interface IWriteRepsitory<in T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
    public interface IReadRepository<out T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
    public interface IRepository<T>  :IReadRepository<T>  , IWriteRepsitory<T> 
        where T : IEnity
    {          
    }
    public interface GenericSuperRepository<T, Tkey , TSecrete> : IRepository<T> where T : IEnity
    { 
    }

    public interface ISuperRepository<T, Tkey> : IRepository<T> where T : IEnity
    {

    }
}