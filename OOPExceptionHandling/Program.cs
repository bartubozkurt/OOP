using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro(); 
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);                
            }

            
            Find();
            Console.ReadKey();
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Bartu", "Ali", "Fatih" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found"); 
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        public static void ExceptionIntro()
        {
            try
            {
                string[] student = new string[3] { "Bartu", "Bozkurt", "İzmir" };            // Kodu dene çalışmaz ise catch'e git mantığı ile çalışır.
                student[3] = "asdf";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadKey();
        }
    }
}
