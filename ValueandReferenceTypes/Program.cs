using System;

namespace ValueandReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 30;
            int number2 = 65;
            number1 = number2;
            number2 = 45;
            Console.WriteLine("number1: " + number1 + "   number2: " + number2);   //value type

            int[] numbers1 = { 10, 20, 30 };
            int[] numbers2 = { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine("numbers1[0]: " + numbers1[0] + "   numbers2[0]: " + numbers2[0]);  //reference type

        }
    }
}