using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int sayi = 0;
            while (sayi <= 10)
            {
                sayi++;
                Console.WriteLine(sayi);
            }
            */

            //----------------------------
            /*int i=1;
            int  ttoplam=0;
            while (i<100)
            {
                if (i%2!=0)
                {
                    ttoplam += i;
                }
                  i++;   
            }
            Console.WriteLine("Teklerin Toplamı: "+ttoplam);*/

            //--------------------------------------
            /* Random rastgele = new Random();
             int sayi = rastgele.Next(0, 101);
             while (true)
             {
                 Console.WriteLine("Sayı tahmin ediniz: ");
                 int tahmin = Convert.ToInt32(Console.ReadLine());
                 if (sayi == tahmin)
                 {
                     Console.WriteLine("Doğru bildiniz: ");
                 }
                 else if (sayi < tahmin)
                 {
                     Console.WriteLine("Küçük değer giriniz: ");
                 }
                 else if (sayi > tahmin)
                 {
                     Console.WriteLine("Büyük sayı giriniz: ");
                 }
             }
            */
            //-------------------------------------------
            /*            int i = 0;
                        Random rastgele = new Random();
                        while (i<=9)
                        {
                            int sayi = rastgele.Next(249, 1001);
                            if (sayi % 2 == 0)
                            {
                                Console.WriteLine(sayi);
                                i++;
                            }
                        }
            */

            //-------------------------------------------------------
            /*int yil = 2006;
            Console.WriteLine("Kiranızı giriniz:");
            int kira = Convert.ToInt32(Console.ReadLine());
            while (yil<=2022)
            {
                kira += kira * 25 / 100;
                Console.WriteLine(yil+" yılındaki kira: "+kira);
                 yil++;
            }*/

            /*int toplam = 0;
             while (true)
             {
                 Console.WriteLine("Sayı giriniz: ");
                 int sayi = Convert.ToInt32(Console.ReadLine());
                 if (sayi>=0)
                 {
                     toplam += sayi;
                 }
                 else
                 {
                     break;
                 }
             }
             Console.WriteLine("Sayıların toplamı: "+toplam);*/



            /*


            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi != 15)
                {
                     toplam += sayi;
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine("Sayıların toplamı: " + toplam); */


            /*
            Random rastgele = new Random();
            int toplam = 0;
            while (true)
            {
                int sayi = rastgele.Next(0, 101);
                Console.WriteLine(sayi);
                toplam += sayi;
                if (toplam>=1000)
                {
                    break;
                }
            }
            Console.WriteLine("sayıların toplamı: "+toplam);*/

            //------------------------------------------------------------------------
            /*
            Random rastgele = new Random();
            int toplam = 0;
            while (true)
            {
                int sayi = rastgele.Next(0, 101);          
                if (sayi%5==0 && sayi%7==0)
                {
                    Console.WriteLine(sayi);
                    toplam += sayi;
                    if (toplam > 500)
                    {
                        break;
                    }
                }
            }
            
            Console.WriteLine("sayıların toplamı: " + toplam);*/
            //--------------------------------------------------


            //Not         //String ifadelerle + işareti birleştirici özelliğe sahiptpir.
            /*            char harf = ' ';
                        string birlestir = null;
                        while (harf!='0')
                        {
                            Console.Write("Bir harf giriniz: ");
                            harf = Convert.ToChar(Console.ReadLine());

                            if (harf!='0')
                            {
                                birlestir += harf;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine(birlestir);
            */
            //------------------------------------------------
            Console.WriteLine("sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Random rastgele = new Random();
            int sayac=0,sayac1=0;
            while (sayac<=2)
            { 
                int sayi = rastgele.Next(0, 101);
                Console.Write(sayi+" ");
                if (sayi == sayi1)
                {
                    sayac++;
                }
                sayac1++;

            }

            Console.WriteLine("----------"+sayac1+"Defada bulundu");


            Console.ReadLine();
        }
    }
}
