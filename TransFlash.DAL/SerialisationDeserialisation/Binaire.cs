using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TransFlash.DAL.SerialisationDeserialisation
{
    public class Binaire<T>
    {
        private BinaryFormatter bf = new BinaryFormatter();

        public void Serialisation(string fileName, List<T> listes)
        {
            StreamWriter sw = null;
            try
            {
                using(sw = new StreamWriter(fileName))
                {
                    bf.Serialize(sw.BaseStream, listes);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw?.Close();
                sw?.Dispose();
            }
        }

        public List<T> Deserialisation(string fileName)
        {
            List<T> listes = new List<T>();
            StreamReader sr = null;
            try
            {
                using(sr = new StreamReader(fileName))
                {
                    if (File.ReadAllText(fileName) != string.Empty)
                    {
                        List<T> newListes = (List<T>)bf.Deserialize(sr.BaseStream);
                        foreach (var item in newListes)
                            listes.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sr?.Close();
                sr?.Dispose();
            }
            return listes;
        }
    }
}
