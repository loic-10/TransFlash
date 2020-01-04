using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.DAL
{
    public interface IDAL<T>
    {
        int IndexOf(T item);
        T this[int index] { get; set; }
        void Add(T item);
        void Set(T item);
        T Get(T item);
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Remove(T item);
        void Edit(T oldItem, T newItem);
        List<T> AllItems { get; }
        int Count { get; }
        bool IsReadOnly { get; }
        bool Contains(T item);
        void Clear();
    }
}
