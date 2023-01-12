using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sabit değişkenli dizinin elemanlarını gösterir
            //int[] diz = new int[3];
            //int[] sayilar = new int[3];
            //sayilar[0] = 5;
            //sayilar[1] = 12;
            //sayilar[2] = 72;
            //Console.WriteLine("Dizimin ilk elemanı: "+sayilar[0]);
            //Console.WriteLine("Dizimin ikinci elemanı: "+sayilar[1]);
            //Console.WriteLine("Dizimin üçüncü elemanı: "+sayilar[2]);


            //Diziyi gösteren kod--------------------------------------------------
            //int[] yaslar = { 14, 25, 22, 32, 47 };
            //foreach (int yas in yaslar)
            //{
            //    Console.WriteLine("Yaşlar: "+yas);
            //}


            //Dizinin uzunluğu kadar değer girip çıktısını verir------------------------------------------
             //string[] isim = new string[5];
             //for (int i = 0; i < isim.Length; i++)
             //{
             //    Console.WriteLine(i + 1 + ".isim giriniz: ");
             //    isim[i] = Console.ReadLine();
             //}
             //Console.Clear();
             //Console.WriteLine("-------- Çıktı ---------");
             //for (int i = 0; i < isim.Length; i++)
             //{
             //    Console.WriteLine("isim: "+isim[i]);
             //}

            //Girilen sayıları diziye atıp ortalamasını bulan kod---------------------------------
            //int bol = 0;
            // int toplam = 0;
            // int[] sayi = new int[6];
            // for (int i = 0; i < 6; i++)
            // {
            //     Console.WriteLine(i+1+".Sayıyı giriniz: ");
            //     sayi[i] = Convert.ToInt32(Console.ReadLine());
            //     toplam += sayi[i];

            // }
            // bol = toplam / sayi.Length;
            // Console.WriteLine("Sayıların ortalaması: "+bol);

            //Girilen isimleri tersten yazan program---------------
            //string[] isim = new string[5];
            //for (int i = 0; i < isim.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ".isim giriniz: ");
            //    isim[i] = Console.ReadLine();
            //}
            //Console.Clear();
            //Console.WriteLine("-------- Çıktı ---------");
            //for (int i=isim.Length-1 ; i>=0; i--)
            //{
            //    Console.WriteLine("isim: " + isim[i]);
            //}
            

            //smi tersten yazan--------------------------
            
             Console.WriteLine("isim giriniz: ");
             string isim1= Console.ReadLine();
             char[] isim = new char[isim1.Length];
             for (int i = 0; i < isim1.Length; i++)
             {
                 isim[i] = isim1[i];
             }
             for (int i = isim1.Length-1; i >=0; i--)
             {
                 Console.Write(isim[i]);
             }
            

            //-----zamlı fiyatlar--------------------------------
            /*Random rastgele = new Random();
            int[] fiyatlar = new int[5];
            int[] zamli = new int[5];
            for (int i = 0; i <fiyatlar.Length; i++)
            {
                fiyatlar[i] = rastgele.Next(100, 501);
                if (fiyatlar[i]>100 && fiyatlar[i]<200)
                {
                    zamli[i] =fiyatlar[i]+ fiyatlar[i] * 1 / 100;
                    
                }
                else if (fiyatlar[i] > 200 && fiyatlar[i] < 400)
                {
                    zamli[i] = fiyatlar[i] + fiyatlar[i] * 5 / 100;
                    
                }
                else if (fiyatlar[i] > 400 )
                {
                    zamli[i] = fiyatlar[i] + fiyatlar[i] * 10/ 100;
                   
                }

            }
            for (int i = 0; i < zamli.Length; i++)
            {
                
                Console.WriteLine("normal fiyat= "+fiyatlar[i]+"--> "+i+1+". zamlı fiyat= "+zamli[i]);
            }*/


            //------------------------------------------------------------------------------------------------
            /*int[] deger = new int[5];
            int carp = 1, top = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                deger[i] = sayi;
                if (deger[i]%2==0 )
                {
                    carp *= deger[i];
                }
                else
                {
                    top += deger[i];
                }
            }
            Console.Write("Diziniz: ");
            for (int i = 0; i < deger.Length; i++)
            {
                Console.Write("{"+deger[i]+"}");
            }
            
            Console.WriteLine("\nÇiftlerin çarpımı: "+carp);
            Console.WriteLine("Teklerin toplamı: "+top);*/


            //--------------------------------------------------------------
            /*int adet = 0;
            Random rastgele = new Random();
            int[] deger = new int[15];
            for (int i = 0; i < deger.Length; i++)
            {
                deger[i] = rastgele.Next(19, 101);
                Console.Write(deger[i]+" ");
                if (deger[i] % 5 == 0 && deger[i] % 8 == 0)
                {
                    adet++;

                }
            }
          
            
            Console.WriteLine("Adet: "+adet);*/

            //--------------------------------------------------------------------------
            /*
            int[] sayi = new int[5];
            int[] kare = new int[5];
            int toplam = 0, ktoplam = 0;
            for (int i = 0; i <sayi.Length; i++)
            {
                Console.WriteLine(i + 1 + ".Sayıyı giriniz: ");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayi[i];
            }
            for (int i = 0; i < sayi.Length; i++)
            {
                kare[i] = sayi[i] * sayi[i];
                ktoplam += kare[i];
            }
            Console.WriteLine( );
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine("Dizinin "+i+" . elemanı "+sayi[i]);
            }
            Console.WriteLine( );
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine("Sayıların kareleri :" +kare[i]);
            }
            Console.WriteLine( );
            Console.WriteLine("sayıların toplamı: "+toplam);
            Console.WriteLine("sayıların kareleri toplamı: "+ktoplam);*/

            //-------------------------------------------------------------------------------------
            /*int[] sayi = new int[10];
            int[] fiyat = new int[10];
            for (int i = 0; i <sayi.Length; i++)
            {
                Console.WriteLine(i+1+". Ürünün fiyatını giriniz: ");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
                if (sayi[i]>=10 && sayi[i]<=99)
                {
                    fiyat[i] = sayi[i] + sayi[i] * 20 / 100;
                }
                if (sayi[i] >= 100 && sayi[i] <= 999)
                {
                    fiyat[i] = sayi[i] + sayi[i] * 50 / 100;
                }
            }
            for(int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(i+1+". ürünün zamlı fiyatı: "+fiyat[i]);
            }*/


            //----------------------------------------------------------------
            //Random rastgele = new Random();
            // int[] deger = new int[10];
            // int adet = 0,toplam=0;
            // for (int i = 0; i < deger.Length; i++)
            // {
            //     deger[i] = rastgele.Next(99, 501);
            //     Console.Write(deger[i]+"-");
            //     if (deger[i] % 10 == 0)
            //     {
            //         adet++;
            //     }
            //     else
            //     {
            //         toplam += deger[i];
            //     }
            // }
            // Console.WriteLine( );
            // Console.WriteLine( );
            // Console.WriteLine("Sonu sıfırla biten sayıların adedi: "+adet);
            // Console.WriteLine("Sonu sıfırla bitmeyen sayıların toplamı: "+toplam);

            //int[] sayi = new int[5];
            //int[] pozi = new int[5];
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine("Sayı giriniz: ");
            //    sayi[i] = Convert.ToInt32(Console.ReadLine());
            //    if (sayi[i]<0)
            //    {
            //        pozi[i] = sayi[i]*(-1);
            //    }

            //}
            //Console.WriteLine("Sayıların pozitif hali");
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.Write(pozi[i]+" ");
            //}

            //--Şehirler sorusu-------------------------------------

            //int sayac = 0;
            //Console.WriteLine("Dizinin boyutunu giriniz: ");
            //int boyut = Convert.ToInt32(Console.ReadLine());
            //string[] sehir = new string[boyut];
            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    Console.WriteLine("Şehir Giriniz: ");
            //    sehir[i] = Console.ReadLine();
            //}
            //Console.Clear();
            //Console.WriteLine("Aramak istediğiniz şehri yazınız: ");
            //string arama = Console.ReadLine();
            //for (int i = 0; i < sehir.Length; i++)
            //{
            //    if (sehir[i] == arama)
            //    {
            //        sayac++;
            //    }

            //}
            //Console.WriteLine(sayac + " Adet bulundu.");

            //--En uzun metini, indisini, karakterini bulan kod-------------------------------------
            //int uzunluk = 0, indis = 0;
            //string enuzun = "";
            //string[] dizi = new string[5];
            //int[] sayi = new int[5];
            //for (int i = 0; i <5; i++)
            //{
            //    Console.WriteLine(i+".elemanı Giriniz: ");
            //    dizi[i] = Console.ReadLine();
            //    if (dizi[i].Length>uzunluk)
            //    {
            //        uzunluk = dizi[i].Length;
            //        enuzun = dizi[i];
            //        indis = i;
            //    }

            //}
            //Console.WriteLine("En uzun metin: "+dizi[indis]);
            //Console.WriteLine("En uzun metin indisi: "+indis);
            //Console.WriteLine("En uzun karakter sayısı: "+uzunluk);


            Console.ReadLine();
        }
    }
}
