using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2,i=0;
            int secim;
            do
            {
                Console.Write("bir sayı giriniz:");
                s1 = double.Parse(Console.ReadLine());
                Console.Write("bir sayı giriniz:");
                s2 = double.Parse(Console.ReadLine());
                Console.WriteLine("------------------");
                Console.WriteLine("1-toplama");
                Console.WriteLine("2-çıkarma");
                Console.WriteLine("3-çarpma");
                Console.WriteLine("4-bölme");
                Console.WriteLine("0-çıkış");
                Console.Write("seçiminiz:");
                secim = int.Parse(Console.ReadLine());
                DortIslem dön = new DortIslem();
                Console.WriteLine("\nsonucunuz=" + dön.islem(secim, s1, s2) + ("\n"));
            } while (secim != 0);
        }
    }
}
