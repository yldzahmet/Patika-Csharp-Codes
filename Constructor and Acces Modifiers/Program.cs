using System;

namespace Class__Instance__Field__Property
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz dizimi 
            // class SınıfAdı
            // {
            //     [Erişim Belirteci] [Veri Tipi] ÖzellikAdı;
            //     [Erişim Belirteci] [Geri Dönüş Tipi] MethodAdı (Parametre Listesi)
            //     {
            //         Method Komutları
            //         ...
            //     }
            // }
            //
            // Erişim Belirteçleri
            // -public
            // -private
            // -protected
            // -internal

            Calısan calısan_1 = new Calısan();
            calısan_1.ad ="Ahmet";
            calısan_1.soyad ="Yıldız";
            calısan_1.departman ="İnsan Kaynakları";          
            calısan_1.no = 91827852;
            calısan_1.ÇalişanBilgileri();

            // Instantiating With Constructor Method.
            Calısan calısan_2 = new Calısan("Kazım","Ünal", "İnsan Kaynakları",71322811);
        }
        class Calısan{
            public string ad, soyad, departman;
            public int no;

            // Paramaterized Constructor
            public Calısan(string ad, string soyad, string departman, int no)
            {
                this.ad = ad;
                this.soyad = soyad;
                this.departman = departman;
                this.no = no;
                ÇalişanBilgileri();
            }
            // Default Constructor
            public Calısan(){}
            public void ÇalişanBilgileri(){
                Console.WriteLine("Çalışanın Adı: " + ad);
                Console.WriteLine("Çalışanın Soyadı: " + soyad);
                Console.WriteLine("Çalışanın Numarası: " + no);
                Console.WriteLine("Çalışanın Departmanı: " + departman);
            }
        }
    }
}
