using System;

namespace Encapsulation_and_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Öğrenci öğrenci_1 =new Öğrenci();
            öğrenci_1.Isim ="Ayşe";
            öğrenci_1.Soyisim ="Kara";
            öğrenci_1.Sınıf = -5;
            öğrenci_1.No = 293;
            öğrenci_1.ÖğrenciBilgileriniGetir();
            öğrenci_1.SınıfAtlat();
            öğrenci_1.ÖğrenciBilgileriniGetir();
        }

        class Öğrenci 
        {
            // Fields
            private string isim, soyisim;
            private int sınıf, no;

            // Properties
            public string Isim 
            { 
                get { return isim; }
                set { isim = value; }    
            }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Sınıf { 
                get 
                {
                    return sınıf;
                } 
                set 
                {   
                    // Set field by condition
                    if(value < 1)
                    {
                        Console.WriteLine("Sınıf 1'den küçük olamaz.");
                        sınıf = 1;
                    }  
                    else
                        sınıf = value;
                } 
            }
            public int No { get => no; set => no = value; }

            // Default Constructor
            public Öğrenci(){}

            // Paramerized Constructor
            public Öğrenci(string isim, string soyisim, int sınıf, int no)
            {
                Isim = isim;
                Soyisim = soyisim;
                Sınıf = sınıf;
                No = no;
            }

            public void ÖğrenciBilgileriniGetir()
            {
                Console.WriteLine("Öğrenci Adı: " + Isim);
                Console.WriteLine("Öğrenci soyadı: " + Soyisim);
                Console.WriteLine("Öğrenci sınıfı: " + Sınıf);
                Console.WriteLine("Öğrenci numarası: " + No);
            }
            public void SınıfAtlat(){
                this.sınıf++;
                Console.WriteLine("{0} sınıf atladı.", Isim);
            }
            public void SınıfDüşür(){
                this.sınıf--;
                Console.WriteLine("{0} sınıf düştü.", Isim);
            }
        } 
    }   
}
