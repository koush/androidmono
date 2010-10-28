using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace MonoDroid
{
    /// <summary>
    /// This abstract class provides a wrapper class around a Dictionary<K,V> type to make it serializable.
    /// It does this by providing access directly to the Values collections when implementing ICollection<V>
    /// Override the GetKey method to retrieve the key from a value type when deserializing.
    /// </summary>
    /// <typeparam name="K">Key type</typeparam>
    /// <typeparam name="V">Value type</typeparam>
    public abstract class SerializableDictionary<K, V> : ICollection<V>
    {
        public SerializableDictionary()
        {
            myDictionary = new Dictionary<K, V>();
        }

        public SerializableDictionary(SerializableDictionary<K, V> other)
        {
            myDictionary = new Dictionary<K, V>(other.Dictionary);
        }

        Dictionary<K, V> myDictionary;

        /// <summary>
        /// Get the underlying dictionary
        /// </summary>
        public Dictionary<K, V> Dictionary
        {
            get { return myDictionary; }
        }

        protected abstract K GetKey(V value);

        public void Remove(K key)
        {
            myDictionary.Remove(key);
        }

        #region ICollection<V> Members
        public void Add(V value)
        {
            myDictionary.Add(GetKey(value), value);
        }

        public bool Contains(V item)
        {
            return Dictionary.ContainsKey(GetKey(item));
        }

        public void CopyTo(V[] array, int arrayIndex)
        {
            myDictionary.Values.CopyTo(array, arrayIndex);
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(V item)
        {
            return myDictionary.Remove(GetKey(item));
        }

        #endregion

        #region IEnumerable<V> Members

        public IEnumerator<V> GetEnumerator()
        {
            return myDictionary.Values.GetEnumerator();
        }

        public void Clear()
        {
            myDictionary.Clear();
        }

        public int Count
        {
            get
            {
                return myDictionary.Count;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return myDictionary.Values.GetEnumerator();
        }

        #endregion
    }
}
