using GenericsPractice2.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GenericsPractice2.Repositories
{
    public class GenericRepository<T> where T : EntityBase
    {
        private readonly List<T> _itemList = new();

        public T GetById(int id)
        {
            return _itemList.Single(x => x.Id == id);
        }
        public void Add(T item)
        {
            item.Id = _itemList.Count + 1;
            _itemList.Add(item);
        }
        public void Remove(T item)
        {
            _itemList.Remove(item);
        }
        public void Save()
        {
            foreach (var item in _itemList)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
