using System;

namespace puzzel1
{
    class Program
    {
        static void Main(string[] args)
        {
            int allcount = 0;
            int count = 0;
            while (allcount < 1000)
            {
                if (allcount % 3 == 0 || allcount % 5 == 0)
                {
                    count = count + allcount;
                    Console.WriteLine(count);
                }
                allcount++;
            }
            Console.WriteLine("the sum is " + count);
        }
    }
}
