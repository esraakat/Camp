using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Esra", 21);
            myDictionary.Add("Ferhat", 19);
            myDictionary.Add("Yusuf", 17);
            myDictionary.Add("Eylem", 15);
            Console.WriteLine(myDictionary.Count);
        }
    }
}
