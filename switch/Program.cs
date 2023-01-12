using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------Burçlar--------------------
            //dön:
            //Console.WriteLine("Burcunuzu elementini giriniz: ");
            //string burc = Console.ReadLine();
            //switch (burc)
            //{
            //    case "hava":
            //        Console.WriteLine("serap hoca,elif,ilknur,seda,aslıhan,leyla");
            //        break;
            //    case "su":
            //        Console.WriteLine("Yasemin,elvan");
            //        break;
            //    case "Ateş":
            //        Console.WriteLine("ayşe,rabia,nihal");
            //        break;
            //    case "Toprak":
            //        Console.WriteLine("Şevval,şerife,esra,berfin");
            //        break;
            //    default:
            //        Console.WriteLine("Böyle bir element yok");
            //        goto dön;
            //        break;
            //}
            //--------------------------------------------------------------------
            //Console.WriteLine("1-Gömlek");
            //Console.WriteLine("2-Pantolon");
            //Console.WriteLine("3-Etek");
            //int deger = Convert.ToInt32(Console.ReadLine());
            //switch (deger)
            //{
            //    case 1:
            //        Console.WriteLine("Gömlek Ekranı");
            //        Console.WriteLine("Aşağıdaki menüden beden seçiniz: ");
            //        Console.WriteLine("S\nM\nL");
            //        char beden = Convert.ToChar(Console.ReadLine());
            //        switch (beden)
            //        {
            //            case 'S':
            //                Console.WriteLine("Fiyat: "+100+" TL dir.");
            //                break;
            //            case 'M':
            //                Console.WriteLine("Fiyat: " + 200 + " TL dir.");
            //                break;
            //            case 'L':
            //                Console.WriteLine("Fiyat: " + 300 + " TL dir.");
            //                break;
            //            default:
            //                Console.WriteLine("Bu beden mevcut değildir.");
            //                break;
            //        }

            //        break;
            //    case 2:
            //        Console.WriteLine("Pantolon Ekranı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Etek Ekranı");
            //        break;
            //    default:
            //        Console.WriteLine("Bu ürün mağazada mevcut değildir.");
            //        break;
            //}
            //-------------------------------------------------------------------------------------
            //Console.WriteLine("Merhaba\n1-Tv\n2-Notebook");
            //int sec = Convert.ToInt32(Console.ReadLine());
            //switch (sec)
            //{
            //    case 1:
            //        Console.WriteLine("a-LCD\nb-Plazma");
            //        char deger = Convert.ToChar(Console.ReadLine());
            //        switch (deger)
            //        {
            //            case 'a':
            //                Console.WriteLine("Marka giriniz: ");
            //                string marka = Console.ReadLine();
            //                Console.WriteLine("Fiyat Giriniz: ");
            //                double fiyat = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Ekran inçini giriniz: ");
            //                double inc = Convert.ToDouble(Console.ReadLine());
            //                if(marka=="samsung" && inc<10)
            //                {
            //                    fiyat = fiyat - fiyat * 10 / 100;
            //                    Console.WriteLine(marka+" fiyatı "+fiyat+" TLdir.");
            //                }
            //                else if (marka=="beko" && inc>=10)
            //                {
            //                    fiyat = fiyat - fiyat * 15 / 100;
            //                    Console.WriteLine(marka + " fiyatı " + fiyat + " TLdir.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine(marka + " fiyatı " + fiyat + " TLdir.");
            //                }
            //                break;

            //            case 'b':
            //                Console.WriteLine("Smart özelliği varmı? E/e: ");
            //                char sec1= Convert.ToChar(Console.ReadLine());
            //                Console.WriteLine("Fiyat Giriniz: ");
            //                double fiyat1 = Convert.ToDouble(Console.ReadLine());
            //                if (sec1=='E' || sec1=='e')
            //                {
            //                    fiyat1 = fiyat1 - fiyat1 * 2 / 100;
            //                    Console.WriteLine("fiyatı " + fiyat1 + " TLdir.");
            //                }
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    case 2:

            //        break;
            //    default:
            //        break;
            //}
            //-------------karayolu hacvayolu-------------------------------
            //Console.WriteLine("Seçim yapınız");
            //Console.WriteLine("1-Karayolları \n2- Hava yolları");
            //int deger = Convert.ToInt32(Console.ReadLine());
            //switch (deger)
            //{
            //    case 1:
            //        Console.WriteLine("Yolcu kapasitesi giriniz: ");
            //        int kapasite = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Fiyat girniz: ");
            //        double fiyat = Convert.ToDouble(Console.ReadLine());
            //        if (kapasite<20)
            //        {
            //            fiyat = fiyat + fiyat * 5 / 100;
            //        }
            //        else if (kapasite>=20 && kapasite<40)
            //        {
            //            Console.WriteLine("Güzergah seçiniz:\na-Şehiriçi\nb-Şehir dışı");
            //            char yol = Convert.ToChar(Console.ReadLine());
            //            switch (yol)
            //            {
            //                case 'a':
            //                    Console.WriteLine("ilçe yazınız:");
            //                    string ilce = Console.ReadLine();
            //                    Console.WriteLine("Bilet fiyatı giriniz: ");
            //                    double bilet = Convert.ToDouble(Console.ReadLine());
            //                    if (ilce=="Maltepe")
            //                    {
            //                        bilet+=2.5 / 100;
            //                        Console.WriteLine("Yeni bilet parası: "+bilet);
            //                    }
            //                    else if (ilce=="Kadıköy")
            //                    {
            //                        bilet += 3.5 / 100;
            //                        Console.WriteLine("Yeni bilet parası: " + bilet);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Bilet paranız: "+bilet);
            //                    }
            //                    break;
            //                case 'b':
            //                    Console.WriteLine("İl Seçin\n1-Ankara\n2-İstanbul\n3-İzmir");
            //                    int il = Convert.ToInt32(Console.ReadLine());
            //                    Console.WriteLine("Bilet parası giriniz: ");
            //                    double ibilet = Convert.ToDouble(Console.ReadLine());
            //                    switch (il)
            //                    {
            //                        case 1:
            //                            ibilet += 18 / 100 + (ibilet * 2 / 100);
            //                            Console.WriteLine("Ankara yeni bilet ücreti: "+ibilet);
            //                            break;
            //                        case 2:
            //                            Console.WriteLine("Adet giriniz: ");
            //                            int adet = Convert.ToInt32(Console.ReadLine());
            //                            if (adet==2)
            //                            {
            //                                ibilet = ibilet+ibilet*8 / 100;
            //                                Console.WriteLine("İstanbul yeni bilet ücreti: " + ibilet);
            //                            }
            //                            else
            //                            {
            //                                Console.WriteLine("Bilet fiyatı : "+ibilet);
            //                            }
                                        
            //                            break;
            //                        case 3:
            //                            ibilet += 1 / 100;
            //                            Console.WriteLine("İzmir yeni bilet ücreti: " + ibilet);
            //                            break;

            //                        default:
            //                            break;
            //                    }
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //        break;
            //    case 2:
            //        Console.WriteLine("Seçim yapınız: \na-Pegasus\nb-THY");
            //        char secim = Convert.ToChar(Console.ReadLine());
            //        Console.WriteLine("Fiyat giriniz:");
            //        double fiyat1 = Convert.ToDouble(Console.ReadLine());
            //        switch (secim)
            //        {
            //            case 'a':
            //                Console.WriteLine("Seçim yapınız: \na-yurtiçi\nb-yurtdışı");
            //                char alan = Convert.ToChar(Console.ReadLine());
            //                Console.WriteLine("Gidiş/ Gidiş Dönüş/ Dönüş seçiniz:");
            //                string hareket = Console.ReadLine();
            //                if (hareket=="Gidiş Dönüş" || hareket=="gidiş dönüş")
            //                {
            //                    fiyat1 = (fiyat1 - fiyat1 * 15 / 100)*2;
            //                    Console.WriteLine("Bilet fiyatı: "+fiyat1);
            //                }
            //                break;
            //            case 'b':
            //                Console.WriteLine("Gidiş yeri seçiniz: Avrupa/Avrupa Dışı: ");
            //                string yer = Console.ReadLine();
            //                if (yer=="Avrupa" || yer=="avrupa")
            //                {
            //                    fiyat1 = fiyat1+fiyat1 * 10 / 100;
            //                    Console.WriteLine("Bilet fiyatı: "+fiyat1);
            //                }
            //                else if (yer=="Avrupa Dışı" || yer=="avrupa dışı")
            //                {
            //                    fiyat1 = fiyat1 + fiyat1 * 30 / 100;
            //                    Console.WriteLine("Bilet fiyatı: " + fiyat1);
            //                }
            //                break;
            //            default:
            //                break;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Böyle seçeneğimiz yoktur.");
            //        break;
            //}
            

            Console.ReadLine();
        }
    }
}
