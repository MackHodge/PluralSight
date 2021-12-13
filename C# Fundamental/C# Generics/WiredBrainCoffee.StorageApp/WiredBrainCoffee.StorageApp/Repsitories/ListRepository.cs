using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repsitories
{
    public class ListRepository<T> : IRepository<T> where T : IEnity  
    {
        private readonly List<T> _items = new ();

        public T GetById(int id) 
        {
            return _items.Single(item => item.Id == id);
        }
        public void Add(T item ) { 
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }

        public void Save() 
        {
            foreach (T item in _items)
            {
               //Everything is saved already in the List<T> (read, list of Type T)
            }
        }

        
    }


}
