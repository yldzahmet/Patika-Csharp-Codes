using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Merhaba ";
            string degisken2 ="Hoşgeldiniz ";

            //  Length
            Console.WriteLine(degisken.Length);

            //  ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //  Concat
            Console.WriteLine(String.Concat("Merhaba ", degisken2));

            //  Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //  Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.StartsWith("mer"));
            Console.WriteLine(degisken.EndsWith("haba"));

            //  IndexOf
            Console.WriteLine(degisken.IndexOf("ab"));
            Console.WriteLine(degisken.IndexOf("zz"));

            //  Insert
            Console.WriteLine(degisken.Insert(8, "Dersimiz C#, Hoşgeldiniz."));
            Console.WriteLine(degisken.LastIndexOf("b"));

            //  PadLeft, PadRight
            Console.WriteLine(degisken.PadLeft(30,'*'));
            Console.WriteLine(degisken2.PadRight(30,'_'));  

            //  Remove
            Console.WriteLine(degisken.Remove(4));
            Console.WriteLine(degisken.Remove(2, 4));
            Console.WriteLine(degisken.Remove(0, 4));

            //  Replace
            Console.WriteLine(degisken.Replace("Merhaba", "Selam o.O"));

            //  Split
            Console.WriteLine(degisken.Split(' ')[0]);
            Console.WriteLine(degisken.Substring(3));
            Console.WriteLine(degisken.Substring(3,1));

        }   
    }
}
