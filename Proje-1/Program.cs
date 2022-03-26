using System;

namespace Proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Add members 
            Member.MemberList.Add(new Member("Ahmet", "Yıldız", 123456789));
            Member.MemberList.Add(new Member("Merve", "Boncuk", 456789123));
            Member.MemberList.Add(new Member("Sefa", "Tosun", 654987321));
            Member.MemberList.Add(new Member("Ece", "Yazgı", 258147963));
            Member.MemberList.Add(new Member("Kerim", "Yeşil", 258147963));

            byte selection = 0;
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                selection = (byte)TaskList.ForceLegalInput(String.Empty, "Lütfen geçerli bir sayı giriniz", false);
                
                switch (selection)
                {
                    case 1:
                        TaskList.Insert();
                        break;
                    case 2:
                        TaskList.Delete();
                        break;
                    case 3:
                        TaskList.Update();
                        break;
                    case 4:
                        TaskList.PrintAllMembers();
                        break;
                    case 5:
                        TaskList.GetFoundedMembersList();
                        break;
                    default:
                        break;
                }
            } 
            while (selection >= 0 && selection <= 5);          
        }
    }
}
