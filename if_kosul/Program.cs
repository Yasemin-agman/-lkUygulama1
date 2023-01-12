using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_kosul
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kontrol işlemlerini if else mantığı ile yaparız.
            //if eğer bu işlem ise
            //Else değil ise 
            //mod alma %
            //--------SAYI TEK ÇİFT----------------
            //Console.WriteLine("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int islem = sayi % 2;
            //if (islem==0)
            //{
            //    Console.WriteLine("Sayı çifttir: "+sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir: "+sayi);
            //}
            //----------KULLANICI ADI ŞİFRE GİRME------------------
            //git:
            //Console.WriteLine("Kullanıcı Adını Giriniz: ");
            //string kadi = Console.ReadLine();
            //Console.WriteLine("Şifre giriniz: ");
            //string sifre = Console.ReadLine();
            //if (kadi=="yasemin" && sifre=="1234")
            //{
            //    Console.WriteLine("Bilgiler doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler yanlış.");
            //    Console.Clear();
            //    goto git;
            //}
            //---------------YAŞ VE MEZUNİYETE GÖRE MAAŞ HESAPLAMA---------------
            //Console.WriteLine("Yaşınızı giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mezun durumunu giriniz <lise/önlisans/lisans/Dokora>: ");
            //string mezun = Console.ReadLine();
            //Console.WriteLine("Maaşınızı giriniz: ");
            //float maas = Convert.ToSingle(Console.ReadLine());
            //if (yas > 18 && mezun == "lisans")
            //{
            //    float zam = maas+(maas * 10 / 100);
            //    Console.WriteLine("Yeni Maaşınız: "+zam);

            //}
            //else
            //{
            //    float zam = maas + (maas * 5 / 100);
            //    Console.WriteLine("Yeni Maaşınız: " + zam);
            //}
            //-------------------içiçe if ------------------------
            //Don:
            //Console.WriteLine("Parola giriniz: ");
            //string parola = Console.ReadLine();
            //if (parola == "nihal")
            //{
            //    Console.WriteLine("Prim Günü Giriniz: ");
            //    double prim = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Çalıştığınız yıl giriniz: ");
            //    int yil = Convert.ToInt32(Console.ReadLine());
            //    if(yil>=25 && prim > 5700)
            //    {
            //        Console.WriteLine("Emekli oldunuz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Emekli olamadınız.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış giriş yaptınız: ");
            //    Console.Clear();
            //    goto Don;

            //}

            //--------------------------------------------------------
            //int maas = 6000;
            //Console.WriteLine("Maaşınız: "+maas);
            //Console.WriteLine("Haftalık çalışma saatini giriniz: ");
            //int saat = Convert.ToInt32(Console.ReadLine());
            //if (saat>50)
            //{
            //    Console.WriteLine("Mesai saatini giriniz: ");
            //    int mesai = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Parça sayısını giriniz: ");
            //    int parca = Convert.ToInt32(Console.ReadLine());
            //    if (mesai>7 && parca>100)
            //    {
            //        int zam=maas+500;
            //        Console.WriteLine("Maaşınıza eklenen tutar 500 tl yeni maaşınız: "+zam);
            //    }
            //    else
            //    {
            //        int zam = maas + 200;
            //        Console.WriteLine("Maaşınıza eklenen tutar 200 tl yeni maaşınız: " + zam);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Mesai saatini giriniz: ");
            //    int mesai = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Parça sayısını giriniz: ");
            //    int parca = Convert.ToInt32(Console.ReadLine());
            //    int ücret = mesai * parca + maas;
            //    Console.WriteLine("Yeni ücretiniz: "+ücret);
            //}
            //--------------------4 İŞLEM-----------------------
            //git:
            //    Console.WriteLine("1-Toplama İşlemi: ");
            //    Console.WriteLine("2-Çıkarma İşlemi: ");
            //    Console.WriteLine("3-Çarpma işlemi: ");
            //    Console.WriteLine("4-Yüzde Alma: ");
            //    int islem = Convert.ToInt32(Console.ReadLine());

            //    if (islem == 1)
            //    {
            //        Console.WriteLine("1.sayıyı girin: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("2.sayıyı girin: ");
            //        int sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Toplama Ekranı: ");
            //        int toplam = sayi + sayi1;
            //        Console.WriteLine("Toplama Sonucu: " + toplam);
            //    }
            //    else if (islem == 2)
            //    {
            //        Console.WriteLine("1.sayıyı girin: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("2.sayıyı girin: ");
            //        int sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Çıkarma Ekranı: ");
            //        int cikarma = sayi - sayi1;
            //        Console.WriteLine("Çıkarma Sonucu: " + cikarma);
            //    }
            //    else if (islem == 3)
            //    {
            //        Console.WriteLine("1.sayıyı girin: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("2.sayıyı girin: ");
            //        int sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Çarpma Ekranı:");
            //        int carp = sayi * sayi1;
            //        Console.WriteLine("Çarpma işlemi sonucu: " + carp);
            //    }
            //    else if (islem == 4)
            //    {
            //        Console.WriteLine("1.sayıyı girin: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("2.sayıyı girin: ");
            //        int sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Yüzde Alma Ekranı: ");
            //        float yuzde = sayi * sayi1 / 100;
            //        Console.WriteLine("Yüzde sonucu: " + yuzde);
            //    }
            //    else
            //    {

            //        Console.WriteLine("Yanlış tuşlama yaptınız:");
            //        goto git;
            //    }

            //    Console.WriteLine("İşleme Devam etmek istermisiniz? ");
            //    bool devam = Convert.ToBoolean(Console.ReadLine());
            //    if (devam == true)
            //    {
            //        goto git;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Byby");
            //        Environment.Exit(0);
            //    }
            //----------------------hava sıcaklığı---------------------------------
            //git:
            //    Console.WriteLine("Hava sıcaklığını giriniz: ");
            //    float sicaklik = Convert.ToSingle(Console.ReadLine());
            //    if(sicaklik>5 && sicaklik < 10)
            //    {
            //        Console.WriteLine("Hava Soğuk");
            //    }
            //    else if (sicaklik>10 && sicaklik<20)
            //    {
            //        Console.WriteLine("Hava Ilık");
            //    }
            //    else if (sicaklik>20 && sicaklik<25)
            //    {
            //        Console.WriteLine("Hava Sıcak");
            //    }
            //    else if (sicaklik>25)
            //    {
            //        Console.WriteLine("Hava çok sıcak");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tekrar deneyiniz:");
            //        goto git;
            //    }
            //------------------ÜRÜN KDV---------------------------

            //git:
            //Console.WriteLine("Ürün adını giriniz: ");
            //string urun = Console.ReadLine();
            //Console.WriteLine("Ürün Fiyatını giriniz: ");
            //float fiyat = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Ürün Kodunu giriniz: ");
            //string kod = Console.ReadLine();
            //if (kod =="kdv1")
            //{
            //    float kdv = fiyat + (fiyat * 18 / 100);
            //    Console.WriteLine("KDV'li Tutar: "+kdv);
            //}
            //else if (kod == "kdv2")
            //{
            //    float kdv = fiyat + (fiyat * 8 / 100);
            //    Console.WriteLine("KDV'li Tutar: " + kdv);
            //}
            //else if (kod == "kdv3")
            //{
            //    float kdv = fiyat + (fiyat * 1 / 100);
            //    Console.WriteLine("KDV'li Tutar: " + kdv);
            //}
            //else
            //{     
            //    Console.WriteLine("Yanlış kod girdiniz: " );
            //    goto git;
            //}

            //----------------araç plakası-------------------------
            //Console.WriteLine("Aracın Plakasını giriniz: ");
            //string plaka = Console.ReadLine();
            //Console.WriteLine("Araç Modelini Giriniz: ");
            //string model = Console.ReadLine();
            //Console.WriteLine("Otoparkta kalmak istediğiniz saati giriniz: ");
            //float saat = Convert.ToSingle(Console.ReadLine());
            //if (saat < 2)
            //{
            //    Console.WriteLine("20 TL Ödeyiniz: ");
            //}
            //else if (saat>2 && saat<8)
            //{
            //    Console.WriteLine("50 TL Ödeyiniz: ");
            //}
            //else if (saat>8 && saat<24)
            //{
            //    Console.WriteLine("100 TL Ödeyiniz: ");
            //}
            //else
            //{
            //    Console.WriteLine("Üye olmak ister misiniz?");
            //    string deger = Console.ReadLine();
            //    if(deger=="Evet" || deger == "evet")
            //    {
            //        Console.WriteLine("Aylık Ödeme Tutarı olarak 1000 TL Ödeyiniz:");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sağlıklı günler dileriz.");
            //        Environment.Exit(0);
            //    }
            //}

            //--------------Züccaciye Kodu------------------------------------
            don:
            Console.WriteLine("Öz Züccaciye");
            Console.WriteLine("1-Mutfak gereçleri");
            Console.WriteLine("2-Beyaz Eşya");
            Console.WriteLine("3-Tv Ekranı");
            Console.WriteLine("Seçim yapınız: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("----1-Mutfak gereçleri--");
                Console.WriteLine("a-yemek takımları");
                Console.WriteLine("b-Tencere Takımı");
                Console.WriteLine("Seçim yapınız: ");
                char mgerec = Convert.ToChar(Console.ReadLine());
                if (mgerec == 'a')
                {
                    Console.WriteLine("----a-yemek takımları---------");
                    Console.WriteLine("Marka giriniz: ");
                    string marka = Console.ReadLine();
                    Console.WriteLine("Adet giriniz: ");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fiyat giriniz: ");
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    if(marka=="karaca" && adet>=12)
                    {
                        fiyat *= adet;
                        fiyat = fiyat * 20 / 100;
                        Console.WriteLine("Ödencek Tutar: "+fiyat);
                    }
                    else
                    {
                        fiyat *= adet;
                        fiyat = fiyat * 30 / 100;
                        Console.WriteLine("Ödencek tutar: "+fiyat);
                    }
                }
                else if(mgerec=='b')
                {
                    Console.WriteLine("----b-Tencere Takımları--------");
                    Console.WriteLine("Takım/Parça tercihiniz giriniz:");
                    string tsecim = Console.ReadLine();
                    if (tsecim == "takım")
                    {
                        Console.WriteLine("Malzeme cinsi giriniz: ");
                        string cins = Console.ReadLine();
                        Console.WriteLine("Fiyat giriniz: ");
                        double fiyat1 = Convert.ToDouble(Console.ReadLine());
                        if (cins == "emaye")
                        {
                            fiyat1 -= fiyat1 * 10.5d / 100;
                            Console.WriteLine("Emaye tencere fiyatı: "+fiyat1);
                        }
                        else
                        {
                            Console.WriteLine(cins+"tencere takımı için fiyat: "+fiyat1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parça Satışımız yoktur.");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");
                }
            }
            else if (secim == 2)
            {
                Console.WriteLine("----------2-Beyaz Eşya-------");
                Console.WriteLine("a-Buzdolabı");
                Console.WriteLine("b-Çamaşır makinesi");
                Console.WriteLine("Seçim Yapınız: ");
                char bsecim = Convert.ToChar(Console.ReadLine());
                if (bsecim == 'a')
                {
                    Console.WriteLine("----------Buzdolabı Ekranı-------");
                    Console.WriteLine("M1-Samsung");
                    Console.WriteLine("M2-Bosch");
                    Console.WriteLine("M3-Beko");
                    Console.WriteLine("Seçim Yapınız: ");
                    string Tsecim = Console.ReadLine();
                    Console.WriteLine("Fiyat Giriniz: ");
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    if (Tsecim == "M1")
                    {
                        fiyat = fiyat + fiyat * 8 / 100;
                        fiyat-=2.5d;
                        Console.WriteLine("Samsung için Fiyat: "+fiyat);
                    }
                    else if (Tsecim == "M2")
                    {
                        fiyat = fiyat + fiyat * 18 / 100;
                        fiyat -= 3.5d;
                        Console.WriteLine("Bosch için Fiyat: " + fiyat);
                    }
                    else if (Tsecim=="M3")
                    {
                        fiyat = fiyat + fiyat * 20 / 100;
                        fiyat -= 5.5d;
                        Console.WriteLine("Beko için Fiyat: " + fiyat);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış tuşlama");
                    }
                }
                else if(bsecim=='b')
                {
                    Console.WriteLine("---------Çamaşır Makinesi Ekranı-------------");
                    Console.WriteLine("Kapasitesini giriniz: ");
                    double hacim = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enerhi Sınıfını giriniz:A+/A++: ");
                    string sınıf = Console.ReadLine();
                    Console.WriteLine("Fiyat Giriniz: ");
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    if(hacim>=8 && hacim<=10 && sınıf == "A+")
                    {
                        fiyat = fiyat + fiyat * 8 / 100;
                        fiyat = fiyat + fiyat * 20 / 100;
                        Console.WriteLine("A+ Ödemeniz gereken tutar: "+fiyat);
                    }
                    else if (hacim >= 10 && hacim <= 15 && sınıf == "A++")
                    {
                        fiyat = fiyat + fiyat * 12.5 / 100;
                        fiyat = fiyat + fiyat * 25.5 / 100;
                        Console.WriteLine("A++ için Ödemeniz gereken tutar: " + fiyat);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız:");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız:");
                }
            }
            else if (secim == 3)
            {
             
            }
            else
            {
                Console.WriteLine("Yanlış tuşlama yaptınız tekrar deneyiniz:"); 
            }
            Console.WriteLine("İşleme devam etmek ister misin?");
            string cevap = Console.ReadLine();
            if (cevap == "evet" || cevap == "evet" || cevap == "EVET")
            {
                Console.Clear();
                goto don;
            }
               
            Console.ReadLine();

        }
    }
}
