using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int rsayi = rastgele.Next(0, 21);
            int hak =3;
            while (hak>0)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (hak!=1)
                {
                    if (rsayi==sayi)
                    {
                        Console.WriteLine(" Bildin ");
                        Console.WriteLine(rsayi);
                    }
                    else if (rsayi>sayi)
                    {
                        Console.WriteLine("Sayın küçük daha büyük bir sayı gir. ");
                        hak--;
                    }
                    else
                    {
                        Console.WriteLine("Sayın büyük daha küçük bir sayı gir. ");
                        hak--;
                    }
                }
                else
                {
                    if (rsayi == sayi)
                    {
                        Console.WriteLine(" Bildin ");
                        Console.WriteLine(rsayi);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Canın bitti öldün. ");
                        Console.WriteLine(rsayi);
                        break;
                    }
                    
                  
                }
            }
            Console.ReadLine();
        }
    }
}
