using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaAdi = "deneme.txt";
            string dosyaYolu = @"c:\deneme";
            string hedefYolu = System.IO.Path.Combine(dosyaYolu, dosyaAdi);

            if (System.IO.File.Exists(hedefYolu) == true )
            {
                Console.WriteLine("Zaten mevcut!");
            }
            else
            {
                System.IO.File.Create(hedefYolu);
            }
            Console.ReadLine();
        }
    }
}
