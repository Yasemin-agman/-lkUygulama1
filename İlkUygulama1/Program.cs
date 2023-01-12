using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkUygulama1
{
    class Program
    {
        static void Main(string[] args) //Burası metottur kodlar burada çalışır.
        {
            //Console.WriteLine("Adınızı giriniz: "); //Kullanıcıya çıktı vermek için kullanılır.
            //string metin = "nihal";
            //int yas= 22;
            //string meslek = "Öğretmen";
            //float maas = 5250.1f;
            //char sembol = '*';
            //Console.WriteLine("Adınız: "+metin);
            //Console.WriteLine("Yaşınız: " + yas);
            //Console.WriteLine("Mesleğiniz: " + meslek);
            //Console.WriteLine("Maşınız: " + maas);
            //Console.WriteLine("Sembolünüz: " + sembol);
            //Console.ReadLine(); //Console.ReadKey() aynı işlemi görür. Ekranın sabit kalmasını sağlar.her uygulama altında olmalı.

            string renk = "kırmızı";
            string il = "İstanbul";
            string ilce = "Pendik";
            string takim = "Fenerbahçe";
            float bakiye = 125.5f;
            int fvrakam = 24;
            Console.WriteLine("Renginiz: " + renk);
            Console.WriteLine("İliniz: " + il);
            Console.WriteLine("İlçeniz: " + ilce);
            Console.WriteLine("Takımınız: " + takim);
            Console.WriteLine("Bakiyeniz: " + bakiye);
            Console.WriteLine("En sevdiğiniz rakam: " + fvrakam);
            Console.ReadLine();
        }
    }
}
