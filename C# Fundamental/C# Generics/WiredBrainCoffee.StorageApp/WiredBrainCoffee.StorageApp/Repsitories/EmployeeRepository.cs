using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repsitories
{
   public class GenericRepository<T,TKey>
    {
        public TKey? key { get; set; }
        protected readonly List<T> _items = new ();
        public void Add(T item ) {
            _items.Add(item);
        }

        public void Save() {
            foreach (T item in _items)
            {
                System.Console.WriteLine(item);
            }
        }
    }

    public class GenericRepositoryWithRemove <T> : GenericRepository<T , string>
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
    
}
