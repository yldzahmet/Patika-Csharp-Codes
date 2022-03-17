using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {   
            //  1 den girilen sayı dahil tüm sayıların aritmetik ortasını verir.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayı = int.Parse(Console.ReadLine());
            int sayaç = 1;
            long toplam = 0;
            while(sayaç <= sayı)
            {
                toplam += sayaç;
                sayaç ++;
            }
            Console.WriteLine("Ortalama: " + toplam / sayı);
            
            // 'a' dan 'z' ye kadar tüm harfleri ekrana yazdırır.
            char c = 'a';
            while(c <= 'z')
            {
                Console.WriteLine(c);
                c ++;
            }

            // **Foreach**
            string[] arabalar = {"BMW", "Ford","Toyota", "Nissan"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
