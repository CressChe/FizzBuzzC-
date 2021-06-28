using System;

namespace FizzBuzzC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            var finalNumber = Convert.ToInt32(Console.ReadLine());
            
            for (var i = 1; i <= finalNumber; i++)
            {
                var fizz = "";
                var buzz = "";
                var bang = "";
                var fezz = "";
                var bong = "";
                if (i % 13 == 0)
                {
                    fezz = "Fezz";
                }
                if (i % 11 == 0)
                {
                    bong = "Bong";
                    var bongFinal = "";
                    if (i % 17 == 0)
                    {
                        bongFinal = string.Concat(bong, fezz);
                    }
                    else
                    {
                        bongFinal = string.Concat(fezz, bong);
                    }

                    Console.WriteLine(bongFinal);
                    continue;
                }
                if (i % 3 == 0)
                {
                    fizz = "Fizz";
                }
                if (i % 5 == 0)
                {
                    buzz = "Buzz";
                }
                if (i % 7 == 0)
                {
                    bang = "Bang";
                }
                var final = "";
                if (i % 17 == 0)
                {
                    final = string.Concat(bang, buzz, fezz, fizz);
                }
                else
                {
                    final = string.Concat(fizz, fezz, buzz, bang);
                }
                if (String.IsNullOrEmpty(final)) 
                { 
                    Console.WriteLine(i);
                } 
                else 
                {
                    Console.WriteLine(final);
                }
            }
        }
    }
}

