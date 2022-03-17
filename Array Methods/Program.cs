using System;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Sort 
            int[] sayıDizisi = {2, 20, 15, 7, 700, 92, 264};
            
            Console.WriteLine("** Sırasız dizi **");
            foreach (var item in sayıDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("** Sıralı dizi **");
            Array.Sort(sayıDizisi);
            foreach (var item in sayıDizisi)
            {
                Console.WriteLine(item);
            }

            //  Clear
            Console.WriteLine("** Array Clear **");
            //  Dizinin 2. indexinden itibarn 3 sayıya varsayılan (sıfır) değerini atar.
            
            Array.Clear(sayıDizisi, 2, 3);

            foreach (var item in sayıDizisi)
            {
                Console.WriteLine(item);
            }

            // Reverse
            Console.WriteLine("** Array Reverse **");
            Array.Reverse(sayıDizisi);
            foreach (var item in sayıDizisi)
            {
                Console.WriteLine(item);
            }

            // IndexOf
            Console.WriteLine("** Array IndexOf **");

            Console.WriteLine(
                Array.IndexOf(sayıDizisi, 700)
                );
            
            // Resize
            Console.WriteLine("** Array Resize **");
            Array.Resize<int>(ref sayıDizisi,12);
            sayıDizisi[11] = 23;

            foreach (var item in sayıDizisi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
