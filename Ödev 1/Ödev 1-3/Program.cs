using System;
using System.Collections.Generic;
using System.Linq;

namespace Ödev_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine().TrimEnd()); 

            Console.WriteLine("Enter a sentence with {0} word:", number);

            List<string> words = Console.ReadLine()
            .TrimEnd()
            .Split(" ")
            .ToList();
            words.Reverse();

            Console.WriteLine("Sentence in reverse order:");
            foreach (var item in words)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
