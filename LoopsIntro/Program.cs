using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C Dili";
            string kurs2 = "C++ Dili";
            string kurs3 = "C# Dili";
            string kurs4 = "Python Dili";
            string kurs5 = "Java Dili";

            string[] kurslar = new string[] { "C Dili", "C++ Dili", "C# Dili", "Python Dili", "Java Dili" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü biti.\n");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach döngüsü bitii.\n");

        }

    }
}
//foreach - dizi temelli yapıları tek tek dönmeye yarıyor
//kurs - alians - eleman takma ismi
//Use foreach for arrays.