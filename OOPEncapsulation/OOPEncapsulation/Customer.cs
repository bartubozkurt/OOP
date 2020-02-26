using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEncapsulation
{
    class Customer
    {


        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; }

            // bir değeri okurken get set ederken başka bir şey yapmak 
            //istersek önünde Mr ya da daha farklı bir şey yazmak istersek bu yöntem kullanılır.

            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
