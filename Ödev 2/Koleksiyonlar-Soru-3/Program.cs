using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İçerisindeki ünlü harfleri ayırmak için bir metin girin: ");
            string str = Console.ReadLine();
            string ünlüHarfler = "aeıioöuü";
            ArrayList sequence = new ArrayList();
            Console.WriteLine("Girilen metin içindeki ünlü harfler: ");
            for (int i = 0; i < str.Length ; i++)
            {
                if( Char.IsLetter(str[i]) && 
                    ünlüHarfler.Contains( Char.ToLower(str[i]) ) 
                    )
                    {
                    sequence.Add(str[i]);
                    Console.Write( Char.ToLower(str[i]) );
                    }
            }
        }
    }
}
