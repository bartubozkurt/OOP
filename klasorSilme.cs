using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            string klasorYolu = @"c:\Notlarım\";
            if(System.IO.Directory.Exists(klasorYolu) == true)
            {
                System.IO.Directory.Delete(klasorYolu, true);
                Console.WriteLine("Klasör tüm içeriğiyle birlikte silindi!");
            }
            else
            {
                Console.WriteLine("Klasör mevcut değil!");
            }
            Console.ReadLine();
        }
    }
}
