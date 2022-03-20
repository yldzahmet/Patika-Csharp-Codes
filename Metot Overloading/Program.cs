using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayı = "999";
            bool sonuc = int.TryParse(sayı, out int outSayı);

            if(sonuc)
            {
                Console.WriteLine("Başarılı.");
                Console.WriteLine(outSayı);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Methodlar instance = new Methodlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            // Method Overloading

            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
        }
    }

    class Methodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }

        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
