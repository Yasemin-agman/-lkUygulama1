using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //---1 den 100 kadar olan çift sayıların toplamı----
            int toplam = 0;
            for (int h = 0; h <= 100; h++)
            {
                if (h % 2 == 0)
                {
                    Console.WriteLine(h);
                    toplam += h;
                }


            }
            Console.WriteLine("Sayıalrın Toplamı= " + toplam);

            //---Kullanıcıdan girilen sayıların toplamını yazdıran program-------
            int toplam1 = 0;
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            for (int a = 0; a <= sayi; a++)
            {
                Console.WriteLine(a);
                toplam += a;
            }
            Console.WriteLine("Sayıalrın Toplamı= " + toplam);

            //---5 ile 50 arasındaki sayıaların toplamı--------------------------------------
            int toplam2 = 0;
            Console.WriteLine("--------------------------------------------");
            for (int s = 5; s <= 50; s++)
            {
                if (s % 2 == 0)
                {
                    Console.WriteLine(s);
                    toplam += s;
                }

            }
            Console.WriteLine("Sayıalrın Toplamı= " + toplam);

            //--------1 girilen sayıya kadar 7 tam bölünen sayılar-----------------------------------------
            int toplam3 = 0;
            Console.WriteLine("Sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            for (int d = 1; d <= sayi; d++)
            {
                if (d % 7 == 0)
                {
                    Console.WriteLine(d);
                    toplam += d;
                }
            }
            Console.WriteLine("Sayıalrın Toplamı= " + toplam);

            //-------Çiftlerin teklerin toplamı--------------------------------------------------
            int ctoplam = 0;
            int ttoplam = 0;
            Console.WriteLine("Sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            for (int e = 1; e <= sayi; e++)
            {
                if (e % 2 == 0)
                {
                    ctoplam += e;
                }
                else
                {
                    ttoplam += e;
                }
            }
            Console.WriteLine(" çift Sayıalrın Toplamı= " + ctoplam);
            Console.WriteLine(" tek Sayıalrın Toplamı= " + ttoplam);

            //----------çarpım tablosu------
            int i = 0;
            int j = 0;
            Console.WriteLine("çarpım tablosu");
            Console.WriteLine("Sayı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= sayi1; i++)
            {
                Console.WriteLine(+i + "x" + (i + 1) + "=" + i * (i + 1));
            }

            //-------------------------------------------------------------
            int carp = 1;
            for (int m = 1; m <= 5; m++)
            {
                Console.WriteLine("Sayı giriniz: ");
                int sayi4 = Convert.ToInt32(Console.ReadLine());
                carp = sayi4 * carp;
            }
            Console.WriteLine(carp);

            //-------------------------------------------
            int toplam4 = 0;
            int nadet = 0, padet = 0, adet = 0;
            for (int n = 1; n <= 10; n++)
            {
                Console.WriteLine("sayı giriniz:");
                int sayi5 = Convert.ToInt32(Console.ReadLine());
                if (sayi5 < 0)
                {
                    nadet++;
                }
                else if (sayi5 > 0)
                {
                    padet++;
                }
                else
                {
                    adet++;
                }
            }
            Console.WriteLine("negatiflerin adedi: " + nadet);
            Console.WriteLine("pozitiflerin adedi: " + padet);
            Console.WriteLine("nötürlerin adedi: " + adet);

            //-------------------------------------------------------------
            int ntoplam = 0, ptoplam = 0;
            int ndeger, pdeger;
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine("sayı giriniz:");
                int sayi6 = Convert.ToInt32(Console.ReadLine());
                if (sayi6 % 2 != 0)
                {
                    ndeger = sayi6 * sayi6;
                    ntoplam += ndeger;
                }
                else if (sayi6 % 2 == 0)
                {
                    pdeger = sayi6 * sayi6 * sayi6;
                    ptoplam += pdeger;
                }

            }
            Console.WriteLine("negatiflerin  karesi: " + ntoplam);
            Console.WriteLine("pozitiflerin küpü: " + ptoplam);

            //---10 sayıdan 3 basamaklılarını bulma--------------------------------------
            //int sayac=0,toplam=0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Sayı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if(sayi>=100 && sayi <= 999)
            //    {
            //        sayac+=1;  
            //    }
            //    else
            //    {
            //        toplam += sayi;

            //    }
            //}
            //Console.WriteLine("3 basamaklı sayıların adedi: "+sayac);
            //Console.WriteLine("3 basamaklı olmayan sayıların toplamı: "+toplam);

            //-------Faktöriyel bulma-------------------------------------------------------
            //int fak = 1;
            //Console.WriteLine("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <sayi; i++)
            //{
            //    fak=fak*(i+1);
            //}
            //Console.WriteLine("Sayının faktöriyeli: "+fak);

            //------------------------------------------------------------------------------

            //int fak = 1;
            //Console.WriteLine("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = sayi; i >= 1; i--)
            //{
            //    fak*=i;
            //}
            //Console.WriteLine("Sayının faktöriyeli: " + fak);

            //--Komisyon Sorusu--------------------------------------
            //double kom=0, topkom=0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+1+".Fiyatı giriniz: ");
            //    double mal = Convert.ToDouble(Console.ReadLine());
            //    if (mal <= 50)
            //    {
            //        kom = mal * 3 / 100;
            //        mal += mal * 3 / 100;
            //        Console.WriteLine("Girilen malın komisyonlu fiyatı: "+mal);
            //        Console.WriteLine("Fiyatın komisyonu: "+kom);
            //        topkom+= kom;
            //    }
            //    else
            //    {
            //        kom = mal * 3 / 100;
            //        mal += mal * 3 / 100;
            //        Console.WriteLine("Girilen malın komisyonlu fiyatı: " + mal);
            //        Console.WriteLine("Fiyatın komisyonu: " + kom);
            //        topkom+= kom;
            //    }
            //    Console.WriteLine( );

            //}
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("komisyon toplamları: "+topkom);

            //--üslü ifade bulma---------------
            //int carp = 1;
            //Console.WriteLine("Taban sayısı giriniz:");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üs ifadesini giriniz: ");
            //int üs = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= üs; i++)
            //{
            //    carp*= taban;
            //}
            //Console.WriteLine("Sonuç: "+carp);

            //-------------------------
            //int sonuc = 0,toplam=0;
            //int besincisayi=0;
            //for (int i = 0; i <10; i++)
            //{
            //    Console.WriteLine(i+1+".Sayı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    if (i==4)
            //    {
            //        besincisayi = sayi;                  
            //    }

            //}
            //Console.WriteLine("İşlemin sonucu: "+sonuc/besincisayi);




            Console.ReadLine();
        }
    }
}
