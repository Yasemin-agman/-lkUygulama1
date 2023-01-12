using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin yarıçapını giriniz: ");
            float r = Convert.ToSingle(Console.ReadLine());
            float pi = 3.14f;
            float alan = pi * r * r;
            float cevre = 2 * pi * r;
            Console.WriteLine("Daire alanı: "+alan);
            Console.WriteLine("Daire çevresi: " + cevre);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Dikdörtgenin kısa kenarını giriniz: ");
            float kisa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin uzun kenarını giriniz: ");
            float uzun = Convert.ToSingle(Console.ReadLine());
            float dalan = kisa * uzun;
            float dcevre = kisa + kisa + uzun + uzun;
            Console.WriteLine("Dikdörtgenin Alanı: "+dalan);
            Console.WriteLine("Dikdörtgenin çevre: " + dcevre);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("1.Sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            float toplam = sayi1 + sayi2;
            float bölme = sayi1 / sayi2;
            float carpma = sayi1 * sayi2;
            float cikarma = sayi1 - sayi2;

            Console.WriteLine("Sayıların Toplamı: "+toplam);
            Console.WriteLine("Sayıların çarpımı: "+carpma);
            Console.WriteLine("Sayıların bölümü: " + bölme);
            Console.WriteLine("Sayıların çıkartımı: "+cikarma);
            Console.ReadLine();
        }
    }
}
