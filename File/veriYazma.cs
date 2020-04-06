using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriOkuma
{
    class Program
    {
        static void Main(string[] args)
        { 
            // READ ALL TEXT
            string dosyaYolu = @"c:\deneme1\test.txt";
            string metin = System.IO.File.ReadAllText(dosyaYolu, Encoding.GetEncoding("windows-1254"));
            Console.Write(metin);
            Console.ReadKey();

            // READ ALL LİNES

            string dosyaYolu1 = @"c:\deneme1\test.txt";
            string[] satirlar = System.IO.File.ReadAllLines(dosyaYolu, Encoding.GetEncoding("windows-1254"));

            foreach (string i in satirlar)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();




        }
    }
}
