using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Adı Soyadı: ");
            string adsoyad = Console.ReadLine();
            Console.WriteLine("Yaşı: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bölümü: ");
            string Bolum = Console.ReadLine();
            Console.WriteLine("Cinsiyeti: ");
            char karakter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Adresi: ");
            string adres = Console.ReadLine();
            Console.WriteLine("1. Notu: ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Yaşı: ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            int ortalama = (not1 + not2) / 2;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ad soyad: "+adsoyad);
            Console.WriteLine("Yaşı: "+yas);
            Console.WriteLine("Bölümü: "+Bolum);
            Console.WriteLine("Cinsiyeti: "+karakter);
            Console.WriteLine("Adresi: "+adres);
            Console.WriteLine("1.not: "+not1);
            Console.WriteLine("2.not: " + not2);
            Console.WriteLine("Kanaat Ortalama: "+ortalama);
            Console.ReadLine();

        }
    }
}
