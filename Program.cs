using System;

namespace FizzBuzzC_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                if (i % 7 == 0)
                {
                    Console.WriteLine("Bang");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
