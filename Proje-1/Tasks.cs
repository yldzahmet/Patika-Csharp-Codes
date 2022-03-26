using System;
using System.Collections.Generic;

namespace Proje_1
{
    public class TaskList
    {
        static string name;
        static string surname;
        static int number;

        //  force user to enter correct format and return value which entered correct
        //  otherwise return -1.
        public static int ForceLegalInput(string msg, string errMsg, bool withNewLine)
        {
            bool legalInput = false;
            do
            {   // force user to enter correct format.
                if(withNewLine)
                    Console.WriteLine(msg);
                else
                    Console.Write(msg);
                legalInput = int.TryParse(Console.ReadLine(), out int nmbr);
                if( legalInput)
                    return nmbr;
                else
                    Console.WriteLine(errMsg);
            } 
            while (!legalInput);
            return -1;
        }
        public static void Insert()
        {
            for (int i = 0; i < 3; i++)
            {
                if( i == 0){
                    Console.WriteLine("Lütfen isim giriniz             :");
                    name = Console.ReadLine();
                }
                else if( i == 1){
                    Console.WriteLine("Lütfen soyisim giriniz          :");
                    surname = Console.ReadLine();
                }
                else{
                    number = ForceLegalInput(
                        "Lütfen telefon numarası giriniz:",
                        "Yanlış formatta giriş yapıdı!",
                        true);
                }
            }
            Member.MemberList.Add(new Member(name, surname, number));
            Console.WriteLine("Kayıt başarılı ana sayfaya dönüldü.");
        }
        public static int Search(string keyword)
        {   
            foreach (Member member in Member.MemberList)
            {
                // if name or surname matching
                if(member.Name.ToLower() == keyword.ToLower() || 
                member.Surname.ToLower() == keyword.ToLower())
                {
                    return Member.MemberList.IndexOf(member);
                }
            }
            return -1;
        }
        public static void Delete()
        {
            byte selection = 0;
            do
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                
                int index = Search(Console.ReadLine());
                if( index >= 0 )
                {
                    selection = 0;
                    string str = String.Concat(Member.MemberList[index].Name, " ",  Member.MemberList[index].Surname);
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", str);
                    char ch = char.Parse(Console.ReadLine());
                    if( char.ToLower(ch) == 'y')
                        Member.MemberList.RemoveAt(index);
                    else
                        Console.WriteLine("Silme girişimi başarısız, ana menüye dönülüyor.");
                        return;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    selection = (byte) ForceLegalInput(String.Empty, "Lütfen geçerli bir sayı giriniz", false);
                    if( selection == 1)
                        break;
                    else if( selection == 2)
                        continue;
                    else
                        Console.WriteLine("Silme girişimi başarısız, ana menüye dönülüyor.");
                }
            }
            while (selection != 0);
        }
        public static void Update()
        {
            byte selection = 0;
            do
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                
                int index = Search(Console.ReadLine());
                if( index >= 0 )
                {
                    selection = 0;
                    string str = String.Concat(Member.MemberList[0].Name, " ",  Member.MemberList[0].Surname);
                    int newNumber = TaskList.ForceLegalInput(
                        "{0} Kişisinin yeni numarasını giriniz." + str,
                        "Lütfen geçerli bir sayı giriniz", 
                        true );
                    Member member = Member.MemberList[index];
                    member.Number= newNumber;
                    Member.MemberList[index] = member; 
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    selection = (byte) ForceLegalInput(String.Empty, "Lütfen geçerli bir sayı giriniz", false);
                    if( selection == 1)
                        break;
                    else if( selection == 2)
                        continue;
                    else
                        Console.WriteLine("Güncelleme girişimi başarısız, ana menüye dönülüyor.");
                }
            }
            while (selection != 0);

        }
        public static void PrintAllMembers()
        {
            foreach (var member in Member.MemberList)
            {
                Console.WriteLine("İsim : {0}", member.Name);
                Console.WriteLine("Soyisim : {0}", member.Surname);
                Console.WriteLine("Telefon Numarası : {0} \n - ", member.Number);
            }
        }
        public static void GetFoundedMembersList()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int selection = ForceLegalInput(string.Empty, "Lütfen geçerli bir sayı giriniz!", false);

            if(selection == 1)
            {
                Console.WriteLine("Lütfen aramak için kişinin adını ya da soyadını giriniz:");
                string searchName = Console.ReadLine();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");

                foreach (Member member in Member.MemberList)
                {
                    if(member.Name.ToLower() == searchName || member.Surname.ToLower() == searchName)
                    {
                        Console.WriteLine("İsim : {0}", member.Name);
                        Console.WriteLine("Soyisim : {0}", member.Surname);
                        Console.WriteLine("Telefon Numarası : {0} \n - ", member.Number);
                    }
                }
            }
            else if(selection == 2)
            {
                int numberSearch = ForceLegalInput("Lütfen aramak için kişinin numarasını giriniz:", 
                                                    "Yanlış formatta giriş yapıdı!", 
                                                    true);

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");

                foreach (Member member in Member.MemberList)
                {
                    if(member.Number == numberSearch || member.Number == numberSearch)
                    {
                        Console.WriteLine("İsim : {0}", member.Name);
                        Console.WriteLine("Soyisim : {0}", member.Surname);
                        Console.WriteLine("Telefon Numarası : {0} \n - ", member.Number);
                    }
                }
            }
            else
            {
                Console.WriteLine("Yanlış giriş yapıldı ana menüye dönülüyor.");
            }
        }
    }
}
