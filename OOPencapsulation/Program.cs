using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            //customer.Add();

            customer.City = "İzmir";
            customer.Id = 1;
            customer.FirstName = "Bartu";
            customer.LastName = "Bozkurt";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.City);

            Console.ReadLine();
        }

    }
}
