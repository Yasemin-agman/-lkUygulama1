using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Marka giriniz: ");
            string marka = Console.ReadLine();
            Console.WriteLine("Marka Karakter Giriniz: ");
            char karakter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ücret Giriniz: ");
            int ucret = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zam Oranını Giriniz: ");
            int zamoran = Convert.ToInt32(Console.ReadLine());
            ucret += ucret * zamoran / 100;
            Console.WriteLine("Marka: "+marka);
            Console.WriteLine("Karakter: "+karakter);
            Console.WriteLine("Zamlı Tutar: "+ucret);

            Console.ReadLine();

       }
    }
}
