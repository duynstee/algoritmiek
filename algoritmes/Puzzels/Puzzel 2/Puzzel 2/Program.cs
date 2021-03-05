using System;

namespace Puzzel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1 = 1;
            int number2 = 2;
            int count = 2;
            
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            int numbertransition = 0;
            while (number2 < 4000000)
            {
                numbertransition = number1 + number2;
                number1 = number2;
                number2 = numbertransition;
                if (number2 < 4000000)
                {
                    //Console.WriteLine(number2);
                    if (number2 % 2 == 0)
                    {
                        count = count + number2;
                        Console.WriteLine(count);
                    }

                }
                
            }
        }
    }
}
