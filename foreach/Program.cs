using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string rakamlar = "0123456789";
             string harfler = "abcdefghjklmnoöprsştuüvyz";
             foreach (char rakam in rakamlar)
             {
                 Console.WriteLine("rakamlar: " + rakam); 
             }
             Console.WriteLine(" ");
             foreach (char harf in harfler)
             {
                 Console.WriteLine("Harfler: "+harf);
             }*/

            //-------------------------------------------------------------
            /*string sesli = "aeoöuüıi";
            int sayac = 0;
            Console.WriteLine("Metin giriniz: ");
            string metin = Console.ReadLine();
            foreach (char karakter in metin)
            {
                foreach (char sesliharf in sesli)
                {
                    if (karakter==sesliharf)
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine("Metin uzunluğu= "+metin.Length);
            Console.WriteLine("Metindeki sesli harf sayısı= "+sayac);*/


            string sesli = "aeoöuüıi";
            string sessiz = "bcdklmnbtyrsdzşçpğhjçfgv";
            string karakterler = "*,/,+,-, ,";
            string sayilar = "0123456789";
            int sayac1 = 0,sayac2=0, sayac3=0,sayac4=0;
            Console.WriteLine("Metin giriniz: ");
            string metin = Console.ReadLine();
            int uzun = metin.Length;
            for(int i=0; i<uzun; i++)
            {
                char a=metin[i];
                foreach (char sesliharf in sesli)
                {
                    if (a == sesliharf)
                    {
                        sayac1++;
                    }
                }
                foreach (char sessizharf in sessiz)
                {
                    if (a == sessizharf)
                    {
                        sayac2++;
                    }
                }
                foreach (char karakter in karakterler)
                {
                    if (a==karakter)
                    {
                        sayac3++;
                    }
                }
                foreach (char sayi in sayilar)
                {
                    if (a==sayi)
                    {
                        sayac4++;
                    }
                }
            }
            Console.WriteLine("Metin uzunluğu= " + metin.Length);
            Console.WriteLine("Metindeki sesli harf sayısı= " + sayac1);
            Console.WriteLine("Metindeki sessiz harf sayısı= " + sayac2);
            Console.WriteLine("Metindeki karakter sayısı= " + sayac3);
            Console.WriteLine("Metindeki sayı= " + sayac4);

            Console.ReadLine();
        }
    }
}
