using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atama ve erişim.
            renkler[4] = "Mavi";
            dizi[4] = 78;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[2]);
            Console.WriteLine(renkler[4]);

            //  Döngüler ile dizi kullanımı.
            //  Klavyeden girilen n sayının ortalamasını hesaplar.
            Console.WriteLine("Dizinin eleman sayısını giriniz.");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunluğu];
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.WriteLine("Lütfen {0}. elemanı giriniz.", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
                toplam += sayıDizisi[i];
            }
            ortalama = toplam / sayıDizisi.Length;

            // Foreach ile her bir elemanı yazdırma.
            Console.Write("Dizinin tüm elemanları: ");
            foreach (var item in sayıDizisi)
            {   
                Console.Write("{0}, ",item);
            }
            Console.Write("\n");

            Console.WriteLine("Ortalamaları: {0}", ortalama);
            
        }
    }
}
