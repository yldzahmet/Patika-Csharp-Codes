using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            ArrayList allNumbers = new ArrayList();
            ArrayList max_3 = new ArrayList();
            ArrayList min_3 = new ArrayList();
            bool isValidData;
            float avrMax_3 = 0;
            float avrMin_3 = 0;
            Console.WriteLine("20 adet yan yana sayı giriniz.");
            for (int i = 0; i < 20; i++)
            {
                int number = 0;
                do
                {
                    isValidData = Int32.TryParse(Console.ReadLine(), out int result) ? true :false;
                    if(isValidData)
                        number = result; 
                    else
                        Console.WriteLine("Lütfen geçerli bir tam sayı giriniz !");
                }
                while(!isValidData);
                allNumbers.Add(number);
            }
            allNumbers.Sort();

            // Console.WriteLine("Dizinin tüm elemanları: "); 
            // foreach (var item in allNumbers)
            // {
            //     Console.WriteLine(item);
            // }

            for (int i = 0, j = 17 ; i < 3; i++, j++)
            {
                min_3.Add(allNumbers[i]);
                avrMin_3 += (int)allNumbers[i];

                max_3.Add(allNumbers[j]);
                avrMax_3 += (int)allNumbers[j];
            }

            avrMin_3 /= 3;
            avrMax_3 /= 3;

            Console.WriteLine("En küçük 3 elemanın ortalaması: " + avrMin_3);
            Console.WriteLine("En büyük 3 elemanın ortalaması: " + avrMax_3); 
            Console.WriteLine("İki grubun ortalamaları toplamı " + (avrMax_3 + avrMin_3) );

        }       
    }
}
