using System;

namespace Method_Definition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a - b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Methodlar ornek = new Methodlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            Console.WriteLine(ornek.ArttırVeTopla(ref a, ref b)); 
            ornek.EkranaYazdır(Convert.ToString(a + b));
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }

    class Methodlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int a, ref int b)
        {
            a++;
            b++;
            return a + b;
        }
    }
}
