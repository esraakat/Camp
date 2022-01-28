using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;

            number1 = number2;
            number2 = 65;

            Console.WriteLine("Number1: " + number1);

            int[] numbers1 = { 10, 20 };
            int[] numbers2 = { 100, 200 };
            numbers1 = numbers2;
            numbers2[0] = 99;

            Console.WriteLine(numbers1[0]);

        }
    }
}
