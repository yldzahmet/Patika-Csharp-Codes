using System;

namespace Static_Class_and_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calısan sayısı :{0} ", Calısan.CalışanSayısı);

            Calısan calısan_1 = new Calısan("Ayşe", "Kara", "IK");
            Console.WriteLine("Calısan sayısı :{0} ", Calısan.CalışanSayısı);

            Calısan calısan_2 = new Calısan("Kazım", "Vural", "IK");
            Calısan calısan_3 = new Calısan("Sedef", "Kırmızı", "IT");

            Console.WriteLine("Calısan sayısı :{0} ", Calısan.CalışanSayısı);
            
            Console.WriteLine("Toplama işleminin sonucu :{0} ", Islemler.Topla(125, 670));
            Console.WriteLine("Çıkarma işleminin sonucu :{0} ", Islemler.Cıkar(670, 125));
        }

        class Calısan
        {
            private static int calışanSayısı = 0;
            public static int CalışanSayısı { get => calışanSayısı; }
            private string Isim;
            private string SoyIsim;
            private string Departman;

            
            public Calısan(string isim, string soyIsim, string departman)
            {
                Isim = isim;
                SoyIsim = soyIsim;
                Departman = departman;
                calışanSayısı += 1;
            }

            static Calısan()
            {
                calışanSayısı = 0;
            }
        }

        public static class Islemler
        {
            public static long Topla(int i, int j){
                return i + j;
            }
            public static long Cıkar(int i, int j){
                return i - j;
            }
        } 
    }
}
