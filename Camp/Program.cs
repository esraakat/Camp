using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoriLabel = "Kategori";
            int numberStudents = 3200;
            double interestRate = 1.45;
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;
            bool loginSistem = false;


            Console.WriteLine(categoriLabel);
            Console.WriteLine(categoriLabel);
            Console.WriteLine(categoriLabel);
            Console.WriteLine(categoriLabel);


            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dollarYesterday == dollarToday)
            {
                Console.WriteLine("Değişmedi oku");
            }
            else
            {
                Console.WriteLine("Artış oku");
            }


            if (loginSistem == true)
            {
                Console.WriteLine("Kullancı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}

//type safety - tip güvenliği - use string, int, float ...
//use alias because it can always change.
//categoriLabel is a alias because it is a 
//Do Not Repeat Yourself
//int - tam sayı; double - ondalık sayı; bool - şart blokları