using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> family = new MyDictionary<string, int>();
            family.Add("Ayhan", 43);
            family.Add("Halime", 42);
            family.Add("Esra", 21);
            family.Add("Ferhat", 19);
            Console.WriteLine(family.Count()); 
        }
    }
}