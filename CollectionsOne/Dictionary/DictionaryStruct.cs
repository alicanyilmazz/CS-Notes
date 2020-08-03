using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsOne.Dictionary
{
    class DictionaryStruct
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public void add_KeyValuePair(string _key, string _value)
        {
            dictionary.Add(_key, _value);
        }

        public void find_Value(string _key)
        {
            Console.WriteLine(dictionary[key: _key]);
        }

        public void find_AllKeyValue(string _key)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }

        public void Contains_Key(string _key)
        {
            if (dictionary.ContainsKey(key: _key))
                Console.WriteLine("finded.");
            else
                Console.WriteLine("Not Finded.");
        }

    }
}
