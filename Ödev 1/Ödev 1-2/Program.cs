using System;
using System.Collections.Generic;
using System.Linq;
namespace Ödev_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");

            List<int> divisor = Console.ReadLine()
            .TrimEnd()
            .Split(" ")
            .ToList()
            .Select(a => Convert.ToInt32(a))
            .ToList();

            Console.WriteLine("Enter {0} numbers:", divisor[1]);

            List<int> numbers = Console.ReadLine()
            .TrimEnd()
            .Split(" ")
            .ToList()
            .Select(a => Convert.ToInt32(a))
            .ToList();

            int m = divisor[0];
            Console.WriteLine("Divisors of {0} ", m);
            foreach (var item in numbers)
            {
                if(m % item == 0)
                {
                    Console.WriteLine(item);
                }
                    
            }



        }
    }
}
