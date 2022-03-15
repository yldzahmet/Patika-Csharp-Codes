using System;

namespace conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // imlicit converisions 
            byte b = 200;
            sbyte sb = 10;
            short sh = 27;

            int i = b + sb + sh;
            Console.WriteLine(i);

            long h = i;
            Console.WriteLine(h);

            float f = h;
            Console.WriteLine(f);

            string str = "Cat";
            char c = 'b';
            object o = str + c + f;

            Console.WriteLine(o);

            int t = 15;
            byte by = (byte)t;

            float fl = 1.05f;
            byte by2 = (byte)fl;
            Console.WriteLine(by2);

            // ToString() methodu
            int num = 25;
            string str2 = num.ToString();
            Console.WriteLine(str2);

            // System.Convert() methodu
            string ab ="15", bc ="25";
            int sonuc = Convert.ToInt32(ab) + Convert.ToInt32(bc); 
            Console.WriteLine(sonuc);

            ParseMethodu();
        }

        // Parse methodu
        public static void ParseMethodu(){

            string rakam1 = "165", rakam2 = "85.7";

            int gg = int.Parse(rakam1);
            double dd = double.Parse(rakam2);

            Console.WriteLine("rakam1: " + gg);
            Console.WriteLine("rakam2: " + dd);
        }
    }
}
