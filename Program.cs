using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Bartu",
            //    LastName = "Bozkurt",
            //    Address = "İzmir"
            //};

            //Student student = new Student
            //{
            //    Id = 2,
            //    FirstName = "Ali",
            //    LastName = "Veli",
            //    Departmant = "Computer Science"
            //};
            //Worker worker = new Worker
            //{
            //    Id = 2,
            //    FirstName = "Ayşe",
            //    LastName = "Osman",
            //    Departmant = "Catering"
            //};
            //manager.Add(customer);
            //manager.Add(student);
            //manager.Add(worker);

            // 2

            //CustomerManager customerManager = new CustomerManager(); 
            //customerManager.Add(new OracleCustomerDal());             // Sadece Sql veya Sadece Oracle Veritabanı için ekleme yapar.

            ICustomerDal[] customerDals = new ICustomerDal[2] // Hem Sql hem Oracle veritabanı için ekleme yapar.
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer :IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student :IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Id);
            
        }
    }
}
