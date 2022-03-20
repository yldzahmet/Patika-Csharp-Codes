using System;

namespace Recursive_and_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Recursive - Öz yenileme
            //  3^4 = 3*3*3*3

            int result = 1;
            for (int i = 0; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            // Extension Methods            
            Methodlar methodlar = new Methodlar();
            Console.WriteLine(methodlar.Expo(3,5));

            string ifade = "Ahmet Yıldız";
            bool res = ifade.CheckSpaces();
            Console.WriteLine(res);

            if(res)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {5, 9, 5, 7, 15, 17, 73, 67, 23};
            dizi.SortArray();
            dizi.EkranaYazdır();

            int sayı = 5;
            Console.WriteLine("Is 5 even number: " + sayı.IsEvenNumber());

             string str = "Ahmet";
             Console.WriteLine("Retrieved single char from {0}: {1}", str, str.GetFirstChar());
        }
    }

    class Methodlar
    {
        public int Expo(int sayı, int üs)
        {
            if(üs < 2)
                return 1;
            else    
                return Expo(sayı, üs - 1) * sayı;
        }
        
    }

    public static class Extention
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdır(this int[] param)
        {
            foreach (var item in param)
                Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param %2 == 0;    
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0, 1);
        }

    }
}
