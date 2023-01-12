using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Readkey sadece sabt tutar.
            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            //ToSingle
            float sayi1 = Convert.ToSingle(Console.ReadLine());
            
            float sayi2 = Convert.ToSingle(Console.ReadLine());
            float toplam = sayi1 + sayi2;
            Console.WriteLine("Toplama Sonucu: " + toplam);

            Console.ReadLine();

        }
    }
}
