using System;
using System.Collections.Generic;
using System.Linq;

namespace Ödev_1_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int letterNumber = 0, wordNumber = 0;

            Console.WriteLine("Enter a sentence.");

            List<string> words = Console.ReadLine()
            .TrimEnd()
            .Split(" ")
            .ToList();

            wordNumber = words.Count;
            foreach (var item in words)
            {
                letterNumber += item.Count(char.IsLetter);
            }

            Console.WriteLine("There are {0} words and {1} letters in sentence."
            , wordNumber
            , letterNumber);
        }
    }
}
