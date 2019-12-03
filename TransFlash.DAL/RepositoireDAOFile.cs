using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Multicouche.DAL.SerialisationDeserialisation;

namespace Multicouche.DAL
{
    public class RepositoireDAOFile<T> : IDAL<T>
    {
        private Binaire<T> binaire = new Binaire<T>();
        private List<T> listes = null;
        private string fileName;

        public RepositoireDAOFile()
        {
            if (listes == null)
                listes = new List<T>();
            DirectoryInfo di = new DirectoryInfo("Datas");
            if (!di.Exists)
                di.Create();

            FileInfo fi = new FileInfo($"Datas/{typeof(T).Name}.tf");
            if (!fi.Exists)
                fi.Create().Close();

            fileName = fi.FullName;

            listes = binaire.Deserialisation(fileName);
        }

        public T this[int index]
        {
            get
            {
                return listes[index];
            }
            set
            {
                int newIndex = IndexOf(value);
                if (newIndex == -1 || index == newIndex)
                {
                    listes[index] = value;
                    binaire.Serialisation(fileName, listes);
                }
                else
                {
                    throw new Exception("Element existant !");
                }
            }
        }

        public int Count => listes.Count;

        public bool IsReadOnly => false;

        public int IndexOf(T item)
        {
            return listes.IndexOf(item);
        }

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            if (listes.Contains(item))
                throw new DuplicateWaitObjectException("item");

            listes.Add(item);
            binaire.Serialisation(fileName, listes);
        }

        public bool Contains(T item)
        {
            return listes.Contains(item);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException("predicate");
            return listes.Where(predicate).ToArray();
        }

        public T Get(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            int index = listes.IndexOf(item);
            if (index >= 0)
                return listes[index];
            return default;
        }

        public void Remove(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            if (Get(item) != null)
            {
                listes.Remove(item);
                binaire.Serialisation(fileName, listes);
            }
        }

        public void Set(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");
            int index = listes.IndexOf(item);
            if (index >= 0)
                listes[index] = item;

            binaire.Serialisation(fileName, listes);
        }

        public List<T> AllItems => listes;

        public void Clear()
        {
            listes.Clear();
            File.Delete(fileName);
        }
    }
}
