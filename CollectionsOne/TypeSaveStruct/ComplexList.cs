using CollectionsOne.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsOne.TypeSaveStruct
{
    class ComplexList
    {
        List<Customer> _customerList = new List<Customer>();
        //int count = customerList.Count;
        public void customer_Add(Customer customer)
        {
            _customerList.Add(customer);
        }

        public void customer_Add_To(Customer customer, int index)
        {
            _customerList.Insert(index, customer); // Add() metodu en sona eklerken Insert() ise index değerini nereye verirsek Listenin o kısımına ekler.
        }

        public void customers_Add_To(List<Customer> customer, int index)
        {
            _customerList.InsertRange(index, customer); // Add() metodu en sona eklerken InsertRange() ise index değerini nereye verirsek Listenin o kısımına Liste halinde veri ekler.
        }

        public void Bulk_customer_Add(Customer[] customers)
        {
            _customerList.AddRange(customers); //Listenin sonuna ekler.
        }

        public void Bulk_customer_Add(List<Customer> customers)
        {
            _customerList.AddRange(customers); //Listenin sonuna ekler.
        }

        public void customer_Binary_Search(Customer customer) //Binary Search un dogru calisaması için önce veri Sort edilmedilir aksi halde hatalı sonuc alırız.
        {
            var index = _customerList.BinarySearch(customer);
            Console.WriteLine("Binary Search Result : " + index);
        }
        public void customer_Sort(Customer customer)
        {
            _customerList.Sort();
        }
        public void Delete_This_customer(Customer customer)
        {
            _customerList.Remove(customer);  // Remove() metodu Eğer Listeye aynı elemanı iki kere eklesek dahi sadece ilk buldugunu siler ve işlemi bitirir buna dikkat edelim.
        }

        public void Delete_Predicate_customer(string customername)
        {
            _customerList.RemoveAll(x => x.FirtName == customername);  // RemoveAll() metodu ile mesela FirstName 'i "Alican" olan listedeki tüm elemanları(elemanı değil şarta uyan hepsini bulup siler bu sefer dikkat) silebiliyoruz.
        }
        public void Delete_All_customer(List<Customer> customers)
        {
            _customerList.Clear();
        }

        public string Search_Customer(Customer customer)
        {
            if (_customerList.Contains(customer))
                return "Finded!";
            return "Not finded!";
        }

        public void Find_Customer_BeginFirstIndex(Customer customer)
        {
            var index = _customerList.IndexOf(customer); //Bastan Arama Yapar
            Console.WriteLine("Customer index is : " + index);
        }

        public void Find_Customer_BeginLastIndex(Customer customer)
        {
            var index = _customerList.LastIndexOf(customer); //Sondan Arama Yapar
            Console.WriteLine("List index is : " + index);
        }
        public void Write_All_customer()
        {
            foreach (var customer in _customerList)
            {
                Console.WriteLine("Name : " + customer.FirtName + " Last Name : " + customer.LastName + " Id : " + customer.Id);

            }
        }

    }
}


//// Check the list for part #1734. This calls the IEquatable.Equals method
//// of the Part class, which checks the PartId for equality.

// Console.WriteLine("\nContains: Part with Id=1734: {0}",
//            parts.Contains(new Part { PartId = 1734, PartName = "" }));

//// Find items where name contains "seat".

//        Console.WriteLine("\nFind: Part where name contains \"seat\": {0}", 
//            parts.Find(x => x.PartName.Contains("seat")));

//// Check if an item with Id 1444 exists.

//        Console.WriteLine("\nExists: Part with Id=1444: {0}", 
//        parts.Exists(x => x.PartId == 1444));