using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsOne.ArrayListStruct
{
    class NotTypeSaving
    {
        ArrayList arrayList = new ArrayList(); //Eğer Tip güvenli değerler ile çalışmayacaksak ArrayList kullanabiliriz.

        public void AddToArrayListForInt(int val)
        {
            arrayList.Add(val);
        }

        public void AddToArrayListForString(string val)
        {
            arrayList.Add(val);
        }

        public void WriteToAllArrayList()
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteToThisArrayListMember(int index)
        {
            if(index<arrayList.Count && index>0)
                Console.WriteLine(arrayList[index]);
        }

    }
}
