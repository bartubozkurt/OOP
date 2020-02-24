using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();

            //var result = Add2(20, 30);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2); // Ref Keyword
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            // Console.ReadLine();
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5)); // Method Overloading

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6)); // Params Keyword


            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added !!");
        }
        static int Add2(int number1,int number2)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(ref int number1,int number2) // Ref KeyWord
        {
            number1 = 30;
            return number1 + number2;

        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;

        }
        static int Multiply(int number1, int number2,int number3) //Method Overloading
        {
            return number1 * number2 * number3;

        }
        static int Add4(params int [] numbers) // Params Keyword
        {
            return numbers.Sum();              //Dizideki elemanların toplamı
        }
    }
}
