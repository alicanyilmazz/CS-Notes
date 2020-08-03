using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsOne.TypeSaveStruct
{
    class BasicList
    {
        List<String> memberList = new List<string>();

        public void Add_Member(string  member)
        {
            memberList.Add(member);
        }

        public void WriteAll_Member()
        {
            foreach (var member in memberList)
            {
                Console.WriteLine(member);
            }
        }

        public void WriteThis_Member(int member_index)
        {
            if(member_index>0 && member_index<memberList.Count)
                Console.WriteLine(memberList[member_index]);
        }
    }
}
