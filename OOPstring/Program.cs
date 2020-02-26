using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPstring
{
    class Program
    {
        static void Main(string[] args)
        {
            // string city = "Ankara";
            //// Console.WriteLine(city[0]);

            // foreach (var item in city)
            // {
            //     Console.WriteLine(item);
            // }

            // string city2 = "İstanbul";
            // Console.WriteLine("{0} - {1}",city,city2);
            // Console.ReadLine();


            string sentence = "My name is Bartu Bozkurt";
            var result = sentence.Length;
            Console.WriteLine(result);
            Console.ReadLine();

            bool result2 = sentence.EndsWith("t");     // cümlenin sonunda bu harf ya da kelime var mı?
            bool result3 = sentence.StartsWith("My"); // cümlenin başında bu kelime ya da harf var mı?

            var result4 = sentence.IndexOf("name"); // bulduğu ilk  boşluğu sayar sonra devam etmez
            var result5 = sentence.LastIndexOf("tu"); // Sondan başlar ilk boşluğu sayar diğerlerini saymaz baştan kaçıncı kelime olduğunu gösterir.

            var result6 = sentence.Insert(0, "Hello, "); // ekleme
            var result7 = sentence.Substring(3,4);  // 3. indis hangisi ise ona git onu 1.ci indis gibi al 4. indise kadar git.

            var result8 = sentence.ToLower();    // Küçük harf
            var result9 = sentence.ToUpper();   //Büyük Harf

            var result10 = sentence.Replace("", "-"); // (boşluk yerine ya da istediğiniz özel bir kelime var ("a") gibi - koyuyor) yerine geçmek.
            var result11 = sentence.Remove(2); // istediğiniz indisten itibaren çıkarıyor.

            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            



            Console.ReadLine();


        }
    }
}
