using GenericsIntro;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            Console.WriteLine(names.Count);

            names.Add("Esra");
            names.Add("Esra");
            names.Add("Esra");
            Console.WriteLine(names.Count);
        }
    }
}