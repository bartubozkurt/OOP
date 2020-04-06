using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyayaYazma
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. YÖNTEM DİZİ ELEMANLARINI SATIR SATIR TEXT DOSYASINA YAZDIRMA

            string[] satirlar = { "Öğrenci No : 2017280013", "Adı: Bartu", "Soyadı: Bozkurt" };
            System.IO.File.WriteAllLines(@"c:\deneme\deneme.txt",satirlar);

            // 2. YÖNTEM STRİNG BİR DEEGİSKENİ TEXT DOSYASINA YAZDIRMA

            string info = "Merhabalar benim adım Bartu Bozkurt";
            System.IO.File.WriteAllText(@"c:\deneme\deneme1.txt", info);

            // 3. YÖNTEM BİR DİZİDEKİ YALNIZ İSTENİLEN ELEMANLARI TEXT DOSYASINA YAZDIRMA

            string[] personel = { "PERSONEL : ALİ AKÇAY", "PERSONEL : MUSTAFA KAYA", "MÜDÜR : MELEK KARTAL", "MÜDÜR YARDIMCISI : OSMAN BOZKURT" };

            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"c:\deneme\deneme2.txt"))
            {
                foreach (string satirTut in personel)
                {
                    if(satirTut.Contains("MÜDÜR YARDIMCISI"))
                    {
                        dosya.WriteLine(satirTut);
                    }
                }
            }

            // 4. YÖNTEM VAROLAN BİR TEXT DOSYASINA METİN EKLEME

            using (System.IO.StreamWriter dosya1 = new System.IO.StreamWriter(@"c:\deneme\deneme3.txt", true))
            {
                dosya1.WriteLine("EKLENEN SATIRLAR");
            }
            
        }
    }
}
