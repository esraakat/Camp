using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            Console.WriteLine("Result: " + fourOperations.Sum(5,7)); 
        }
    }
}
