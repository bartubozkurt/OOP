using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2,"Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //Teacher teacher = new Teacher();   static olduğundan newlenmez !

            Teacher.Number = 10;

            Utilities.Validate();

            // class static degil fakat methodlar static olabilir!
            Manager.DoSomething(); // public static DoSomething STATİC !
            Manager manager = new Manager();// public void Do Something2 STATİC DEGİL newlenmiş !
            manager.DoSomething2();
                
                Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items ! ", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added !");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }
    class EmployeeManager
    {
        private ILogger logger;
        public EmployeeManager(ILogger logger)
        {
            this.logger = logger;
        }
        public void Add()
        {
            this.logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        private string entity;
        public BaseClass(string entity)
        {
            this.entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", this.entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
         {

         }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
    static class Teacher
     {
        public static int Number { get; set; }
     }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done!");
        }
        public  void DoSomething2()
        {
            Console.WriteLine("Done2!");
        }
    }
}
