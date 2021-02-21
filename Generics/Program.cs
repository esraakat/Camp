using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>(); //an array type string
            names.Add("Esra");
            names.Add("Engin");
            Console.WriteLine(names.Count);

        }
    }
}
//MyList.count - items number 
//A list is created and then number of items.
//new keyword - create a new reference in memory and instance
//You must give number of items in arrays.