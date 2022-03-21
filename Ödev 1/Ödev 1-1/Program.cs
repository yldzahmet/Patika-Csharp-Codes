using System;
using System.Collections.Generic;
using System.Linq;

namespace Ödev_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Enter {0} numbers: ", arCount);

            List<int> list = Console.ReadLine()
            .TrimEnd()
            .Split(" ")
            .ToList()
            .Select(a => Convert.ToInt32(a))
            .ToList();

            Console.WriteLine("Even numbers in list: ");
            foreach (var item in list)
            {
                if(item % 2 == 0)
                    Console.WriteLine(item);
            }
        }
    }
}
