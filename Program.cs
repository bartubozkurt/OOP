using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary();
            Console.ReadLine();
        }
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public static void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("Mobile Phone", "Cep Telefonu");
            dictionary.Add("Laptop", "Dizüstü Bilgisayar");
            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }
            // var count = dictionary.Count;
            //Console.WriteLine(" Count  : {0}", count);

            Console.WriteLine(dictionary.Count);

            Console.ReadLine();
        }
      


        public static void List()
        {
           
            List<string> cities = new List<string>();
            cities.Add("Adana");
            cities.Add("İzmir");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine(cities.Contains("İzmir")); // listin içinde İzmir içeriyormu onu bakıyor.

            Console.WriteLine("-------------------");

            List<Customer> customers = new List<Customer>
            {
            new Customer  { Id = 2017, Name = "Bartu" },
            new Customer  { Id = 2020, Name = "Melek" }
            };
            var customer2 = new Customer
            {
                Id = 1111,
                Name = "Osman"
            };
            customers.Add(customer2);

            var count = customers.Count;
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 2200, Name ="Ali"},
                new Customer{Id = 6666, Name = "Ayşe"}
            });
            var index = customers.IndexOf(customer2); // kaçıncı sırada ? old.
            Console.WriteLine("İndex : {0}", index);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name);
                // Console.WriteLine(customer.Name);
            }
            Console.WriteLine("Count : {0}", customers.Count);

            Console.ReadKey();
        }
        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities[1]);
            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
    
}
