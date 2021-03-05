using System;

namespace Puzzel_3
{
    class Program
    {
        static void Main(string[] args)
        {

            long number1;
            long number2;
            Console.WriteLine("Please enter your integer: ");
            number1 = 600851475143;

            for (number2 = 2; number1 > 1; number2++)
            {     
                if (number1 % number2 == 0)
                {
                    long x = 0;
                    while (number1 % number2 == 0)
                    {
                        number1 /= number2;
                        x++;
                    }
                    Console.WriteLine($"{number2} is a prime factor {x} times!");
                }
            }
        }
    }
}
