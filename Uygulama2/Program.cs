using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ürün Adını Giriniz: ");
            string urunad = Console.ReadLine();
            Console.WriteLine("Ürün cinsi: ");
            string cins = Console.ReadLine();
            Console.WriteLine("Ürün Garanti Yılı: ");
            int yil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürün Fiyatı Giriniz: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İndirim Tutarını Giriniz:");
            double indirim = Convert.ToDouble(Console.ReadLine());
            //double tutar = fiyat - indirim;
            fiyat -= indirim;
            Console.WriteLine("Ödemeniz Gereken Tutar: "+fiyat);

            Console.ReadLine();
        }
    }
}
