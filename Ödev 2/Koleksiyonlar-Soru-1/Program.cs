using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            
            ArrayList notPrime = new ArrayList();
            ArrayList prime = new ArrayList();
            uint avrPrime = 0;
            uint avrNotPrime = 0;
            Console.WriteLine("20 adet yan yana sayı giriniz.");
            for (int i = 0; i < 20; i++)
            {
                uint number = 0;
                do
                {
                    try{
                        number = Convert.ToUInt32(Console.ReadLine());
                    }
                    catch (Exception){
                        Console.WriteLine("Lütfen pozitif bir tam sayı giriniz !");
                    }
                }
                while(!(number > 0));

                if( IsPrime(number))
                {
                    avrPrime += number;
                    prime.Add(number);
                }
                else
                {
                    avrNotPrime += number;
                    notPrime.Add(number);
                }
            }
            prime.Sort();
            PrintArrayListToScreen(prime, pr);
            notPrime.Sort();   
            PrintArrayListToScreen(notPrime, npr);

            Console.WriteLine("Asal dizinin eleman sayısı: "+ prime.Count);
            Console.WriteLine("Asal dizinin ortalaması: "+ avrPrime/20.0f);

            Console.WriteLine("Asal olmayan dizinin eleman sayısı: " + notPrime.Count);
            Console.WriteLine("Asal olmayan dizinin ortalaması: "+ avrNotPrime/20.0f);
        }

        public static bool IsPrime(uint number)
        {       
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
                
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
            
            return true;        
        }

        static string pr ="Listedeki asal sayılar: ";
        static string npr ="Listedeki asal olmayan sayılar: ";
        public static void PrintArrayListToScreen(ArrayList aList, string msg)
        {   
            Console.WriteLine(msg);
            foreach (var n in aList)
            {
                Console.WriteLine(n);
            }
        }
    }
}
