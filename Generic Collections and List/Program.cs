using System;
using System.Collections.Generic;

namespace Generic_Collections_and_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //  List<T> class
            //  System.Collections.Generic
            //  T-> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(82);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //  foreach ve List.ForEach ile elemanlara erişim
            foreach (var item in renkListesi)
                Console.WriteLine(item);
            foreach (var item in sayiListesi)
                Console.WriteLine(item); 
            
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //  Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.Remove(4);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //  Sayı listei içinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içinde bulundu");
            
            //  Elemen ile indexe erişim
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));
            
            //  Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //  Listeyi temizleme
            hayvanListesi.Clear();

            //  List içerisinde nesne tutma
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı_1 = new Kullanıcılar();
            Kullanıcılar kullanıcı_2 = new Kullanıcılar();

            kullanıcı_1.Isim = "Ahmet";
            kullanıcı_1.Soyisim = "Yıldız";
            kullanıcı_1.Yaş = 28;

            kullanıcı_2.Isim = "Fatih";
            kullanıcı_2.Soyisim = "Yıldız";
            kullanıcı_2.Yaş = 23;

            kullanıcıListesi.Add(kullanıcı_1);
            kullanıcıListesi.Add(kullanıcı_2);

            // Brace initialize and add to list
            kullanıcıListesi.Add( new Kullanıcılar() {
                Isim = "Mehdiye", Soyisim = "Yıldız", Yaş = 27                    
            });
        }
    }

    public class Kullanıcılar
    {
        string isim;
        string soyisim;
        int yaş;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yaş { get => yaş; set => yaş = value; }
    }
}
