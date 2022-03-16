using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Girilen sayıdan küçük eşit ve 0 dan büyük tüm tek sayıları ekrana yazır

            Console.WriteLine("Bir sayı giriniz.");

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }


            //  1000'den küçük eşit tüm tek ve çift sayıları toplar, ayrı ayrı yazdırır.

            int tekToplam = 0, çiftToplam = 0;
            for (int i = 0; i <= 30; i++)
            {
                if(i % 2 == 1)
                {
                    tekToplam +=1 ;
                }
                else
                {
                    çiftToplam += 1;
                }
            }
            Console.WriteLine("Tek sayıların toplarmı : " + tekToplam);
            Console.WriteLine("Çift sayıların toplarmı : " + çiftToplam);
        }
    }
}
