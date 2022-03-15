using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args){

            // Atama ve işlemli atama operatorleri
            int x = 15;
            int y = 25;
            x++;
            x += y;
            y /= 5;

            // Mantıksal operatorler
            // &, |, &&, ||, !
            bool isSucces = true;
            bool isCompeted = false;

            if ( isSucces && isCompeted)
                Console.WriteLine("Perfect");

            if ( isSucces || isCompeted)
                Console.WriteLine("Great");


            // İlişkisel operatorler
            // <, <=, >, >=, ==, != 
            int a = 3;
            int b = 4;

            bool sonuc = a < b ;

            Console.WriteLine(sonuc);
            sonuc = a > b ;
            Console.WriteLine(sonuc);
            sonuc = a <= b ;
            Console.WriteLine(sonuc);
            sonuc = a >= b ;
            Console.WriteLine(sonuc);

            // Aritmetik operatorler
            // +, -, *, /

            int sayı = 54;
            int sayı2 = 107;

            sayı += sayı2;
            Console.WriteLine(sayı);

            sayı *= sayı2;
            Console.WriteLine(sayı);

            sayı = sayı % sayı2;
            Console.WriteLine(sayı);

        }

    }
}
