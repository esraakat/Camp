using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Halil", "Murat", "Kerem" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names = new string[5];
            names[4] = "İlker";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]); //empty element

            List<string> names2 = new List<string> { "Engin", "Murat", "Halil", "Kerem" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);

            List<string> names3 = new List<string>(); //alternative
            names3.Add("Engin");
            names3.Add("Murat");
            names3.Add("Halil");
            names3.Add("Kerem");
            names3.Add("İlker");
            Console.WriteLine(names3[0]);
            Console.WriteLine(names3[1]);
            Console.WriteLine(names3[2]);
            Console.WriteLine(names3[3]);
            Console.WriteLine(names3[4]);

            Console.WriteLine(names3.Count); //number of items

            //List<string> names4 = new List<string> { "Esra", "Ferhat", "Yusuf", "Eylem" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //names4.Add("Elif");
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);
        }
    }
}
