using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOParrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students1 = new string[3]; // Arrays
            //students1[0] = "Engin";
            //students1[1] = "Bartu";
            //students1[2] = "Ali";

            //string[] students2 = { "Engin", "Bartu", "Ali" }; // Second way use Arrays

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };
            
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }
            
            Console.ReadLine();
        }
    }
}
