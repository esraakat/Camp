using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            Console.WriteLine("Sonuc: " + result);
        }

        public void Fark(int sayi1, int sayi2)
        {
            int result = sayi1 - sayi2;
            Console.WriteLine("Sonuc: " + result);
        }

        public void Carpim(int sayi1, int sayi2)
        {
            int result = sayi1 * sayi2;
            Console.WriteLine("Sonuc: " + result);
        }

        public void Bolme(double sayi1, double sayi2)
        {
            if (sayi2 != 0)
            {
                double result = sayi1 / sayi2;
                Console.WriteLine("Sonuc: " + result);
            }
            else
            {
                Console.WriteLine("Bölen 0 olamaz");
            }
        }

    }
}