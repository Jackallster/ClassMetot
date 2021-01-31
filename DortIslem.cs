using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DortIslem
    {
        public double islem(int secim,double s1,double s2)
       {
           double sonuc=0;
           switch (secim)
           {
               case 0:
                   Console.ReadKey();
                   break;
               case 1:
                   sonuc = s1 + s2;
                   break;

               case 2:
                   sonuc = s1 - s2;
                   break;

               case 3:
                   sonuc = s1 * s2;
                   break;

               case 4:
                   sonuc = s1 / s2;
                   break;
           }
           return sonuc;
           
       }
    }
}
