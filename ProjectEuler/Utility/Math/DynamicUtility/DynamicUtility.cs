using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicUtility
{
    public class DynamicUtility
    {
        public static Dictionary<object, object> dynamicDictionary = new Dictionary<object, object>();
        
        public static Func<T, U> Dynamitize<T, U>(Func<T, U> originalFunction)
        {
            Dictionary<T, U> dictionary;
            if (dynamicDictionary.ContainsKey(originalFunction))
            {
                dictionary = (Dictionary<T, U>)dynamicDictionary[originalFunction];
            }
            else
            {
                dictionary = new Dictionary<T, U>();
                dynamicDictionary.Add(originalFunction, dictionary);
            }
            return (T key) =>
            {
                if (dictionary.ContainsKey(key))
                {
                    return dictionary[key];
                }
                var value = originalFunction(key);
                dictionary.Add(key, value);
                return value;
            };
        }
        public static Func<T, U, V> Dynamitize<T, U, V>(Func<T, U, V> originalFunction)
        {
            Dictionary<(T, U), V> dictionary;
            if (dynamicDictionary.ContainsKey(originalFunction))
            {
                dictionary = (Dictionary<(T, U), V>)dynamicDictionary[originalFunction];
            }
            else
            {
                dictionary = new Dictionary<(T, U), V> ();
                dynamicDictionary.Add(originalFunction, dictionary);
            }
            return (T key1, U key2) =>
            {
                if (dictionary.ContainsKey((key1, key2)))
                {
                    return dictionary[(key1, key2)];
                }
                var value = originalFunction(key1, key2);
                dictionary.Add((key1, key2), value);
                return value;
            };
        }
    }
}
