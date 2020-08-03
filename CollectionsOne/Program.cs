using CollectionsOne.ArrayListStruct;
using CollectionsOne.Dictionary;
using CollectionsOne.Entity;
using CollectionsOne.TypeSaveStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList

            //NotTypeSaving notTypeSaving = new NotTypeSaving();
            //notTypeSaving.AddToArrayListForInt(23);
            //notTypeSaving.AddToArrayListForString("alican");
            //notTypeSaving.AddToArrayListForInt(56);
            //notTypeSaving.WriteToAllArrayList();
            //notTypeSaving.WriteToThisArrayListMember(2);


            //List Basic

            //BasicList basicList = new BasicList();
            //basicList.Add_Member("alican");
            //basicList.Add_Member("kemal");
            //basicList.Add_Member("Fatih");
            //basicList.WriteAll_Member();
            //basicList.WriteThis_Member(1);

            //ComplexList

            //ComplexList complexList = new ComplexList();
            //List<Customer> customers = new List<Customer>()
            //{
            //    new Customer(){FirtName="Kemal",LastName="Tanca",Id=21},
            //    new Customer(){FirtName="Hakki",LastName="Vaker",Id=82},
            //    new Customer(){FirtName="Reis",LastName="Serdarogulları",Id=101}
            //};
            //Customer[] customer_array = new Customer[]
            //{
            //    new Customer(){FirtName="Cemal",LastName="Resit",Id=3},
            //    new Customer(){FirtName="Altan",LastName="Ulkek",Id=55},
            //    new Customer(){FirtName="Finasi",LastName="Kerim",Id=31}
            //};
            //Customer customer = new Customer() { FirtName = "alican", LastName = "Yilmaz", Id = 21 };
            //complexList.customer_Add(customer);
            //complexList.Bulk_customer_Add(customers);
            //complexList.Bulk_customer_Add(customer_array);
            //complexList.Write_All_customer();
            ////Customer searched_customer=new Customer() { FirtName = "Cemal", LastName = "Resit", Id = 3 }; // Referans Karsılastırması yapıyor deger değil False döner o yüzden.
            //Console.WriteLine(complexList.Search_Customer(customer_array[1]));
            //complexList.customer_Add(customer); //Bir daha ekledim ki IndexOf Liste basındakini LastIndexOf liste sonundakini bulup dönecek böylece farkı daha iyi anlarsın.
            //complexList.Find_Customer_BeginFirstIndex(customer);
            //complexList.Find_Customer_BeginLastIndex(customer);

            ComplexDictionary complexDictionary = new ComplexDictionary();
            complexDictionary.AddKeyValue();
            complexDictionary.WriteKeyValue();
        }
    }
}


// Benefitical Link : http://www.csharp-examples.net/list/#find-index