using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ogrenci numarasi giriniz : ");
            string ogrNo = Console.ReadLine();
            Console.Write("Kayıt Olunacak ders kodu giriniz : ");
            string dersKodu = Console.ReadLine();

            string klasorYolu = @"c:\test\" + dersKodu;

            if (System.IO.Directory.Exists(klasorYolu) == true)
            {
                string ogrKlasorHedefYolu = @"c:\test\" + dersKodu + "\\" + ogrNo;
                System.IO.Directory.CreateDirectory(ogrKlasorHedefYolu);
                Console.WriteLine("{0} nolu öğrenci {1} nolu derse kayıt oldu!", ogrNo, dersKodu);
            }
            else
            {
                Console.Write("Boyle bir ders yoktur!");
            }

            Console.ReadLine();

        }
    }
}
