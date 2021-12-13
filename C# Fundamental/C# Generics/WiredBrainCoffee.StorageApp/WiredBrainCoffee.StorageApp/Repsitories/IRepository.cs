using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repsitories
{
    public interface IRepository<T> where T : IEnity
    {
        void Add(T item);
        T GetById(int id);
     
        void Remove(T item);
        void Save();
    }
}