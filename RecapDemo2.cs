using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRecapDemo2
{
    interface ILogger
    {
        void log();
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger();
            //customerManager.logger = new FileLogger();
            //customerManager.logger = new Sms();
            customerManager.Add();
            Console.ReadLine();
       }
    }
    class CustomerManager
    {
        public ILogger logger{ get; set; }

        public void Add()
        {
            logger.log();
            Console.WriteLine("Customer Added!");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }
    class FileLogger: ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    class Sms : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to SMS!");
        }
    }
    
}
