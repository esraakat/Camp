using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            var result = Add2(20);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = (Add3(ref number1, number2));
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
        }



        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2 = 20) //default value
        {
            //var result = number1 + number2;
            //return result;
            return number1 + number2;
        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //method overloading 
        //to multiply both 2 and 3 elements
        //You can write 2 method with same name if they have different parameters.
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

    }
}
