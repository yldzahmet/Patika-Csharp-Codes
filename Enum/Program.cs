using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sıcaklık = 24;
            Console.WriteLine(Günler.Pazar);
            if(sıcaklık < (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarı çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if(sıcaklık > (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.Sıcak )
                Console.WriteLine("Hadi dışarıya !!");
            else if(sıcaklık > (int)HavaDurumu.ÇokSıcak )
                Console.WriteLine("Dışar çıkmak için çok sıcak bir gün.");
        }

        public enum Günler{
            Pazartesi, 
            Salı, 
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        public enum HavaDurumu
        {
            Soğuk = 5,
            Normal = 25,
            Sıcak = 25,
            ÇokSıcak = 30,
        }
    }
}
