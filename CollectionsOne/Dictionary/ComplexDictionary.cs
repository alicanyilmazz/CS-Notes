using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsOne.Dictionary
{
    class ComplexDictionary
    {
        enum Keys { code1 = 1, code2 = 2, code3 = 3 };
        enum Values { Error, Warning, Successful };

        Dictionary<Keys, Values> dictionary = new Dictionary<Keys, Values>();

        public void AddKeyValue()
        {
            dictionary.Add(Keys.code1, Values.Error);
            dictionary.Add(Keys.code2, Values.Warning);
            dictionary.Add(Keys.code3, Values.Successful);
        }

        public void WriteKeyValue()
        {
            int i = 0;
            foreach (var item in dictionary)
            {
                Console.WriteLine("Keys : " + dictionary.ElementAt(i).Key + " Values : " + dictionary.ElementAt(i).Value);
                i++;
            }
        }
    }
}
