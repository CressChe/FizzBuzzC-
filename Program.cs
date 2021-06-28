using System;

namespace FizzBuzzC_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a maximum number:");
            var inputNum = Console.ReadLine();
            var finalNumber = 0;
            while (!int.TryParse(inputNum, out finalNumber))
            {
                Console.WriteLine("Please enter a maximum number:");
                inputNum = Console.ReadLine();
            }

            finalNumber = Convert.ToInt32(inputNum);

            Console.WriteLine("Would you like to use Fizz? Type y/n");
            var fizzOn = Console.ReadLine() == "y";

            Console.WriteLine("Would you like to use Buzz? Type y/n");
            var buzzOn = Console.ReadLine() == "y";

            Console.WriteLine("Would you like to use Fezz? Type y/n");
            var fezzOn = Console.ReadLine() == "y";

            Console.WriteLine("Would you like to use Bong? Type y/n");
            var bongOn = Console.ReadLine() == "y";

            Console.WriteLine("Would you like to use Bang? Type y/n");
            var bangOn = Console.ReadLine() == "y";

            Console.WriteLine("Would you like to use Reverse? Type y/n");
            var reverseOn = Console.ReadLine() == "y";


            for (var i = 1; i <= finalNumber; i++)
            {
                var fizz = "";
                var buzz = "";
                var bang = "";
                var fezz = "";
                var bong = "";

                if (i % 13 == 0 && fezzOn) fezz = "Fezz";
                if (i % 11 == 0 && bongOn)
                {
                    bong = "Bong";
                    var bongFinal = "";

                    if (i % 17 == 0 && reverseOn)
                        bongFinal = string.Concat(bong, fezz);
                    else
                        bongFinal = string.Concat(fezz, bong);

                    Console.WriteLine(bongFinal);
                    continue;
                }

                if (i % 3 == 0 && fizzOn) fizz = "Fizz";

                if (i % 5 == 0 && buzzOn) buzz = "Buzz";

                if (i % 7 == 0 && bangOn) bang = "Bang";

                var final = "";
                if (i % 17 == 0 && reverseOn)
                    final = string.Concat(bang, buzz, fezz, fizz);
                else
                    final = string.Concat(fizz, fezz, buzz, bang);

                if (string.IsNullOrEmpty(final))
                    Console.WriteLine(i);
                else
                    Console.WriteLine(final);
            }
        }
    }
}
