using System;
using System.Collections.Generic;
namespace Proje_2
{
    public class TaskList
    {
        //  Static Variables
        public static ToDo toDo;
        public static InProgress inProgress;
        public static Done done;

        //  Static Construtor
        static TaskList()
        {
            //  Instantiate non-static Type and assing to it's own static Type variable.
            toDo = new ToDo();
            inProgress = new InProgress();
            done = new Done();
        }

        //  Force user to enter correct format and return value which entered correct
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

        //  Called from main loop, to insert new cards to ToDo list by default.
        public static void Insert()
        {
            string title = string.Empty;
            string content = string.Empty;
            int id = -1;
            int selection = -1;
            size currentSize = size.XS;

            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {   
                    // Ask user for card information
                    case 0:
                        Console.WriteLine("Başlık Giriniz                                  :");
                        title = Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine("İçerik Giriniz                                  :");
                        content = Console.ReadLine();
                        break;
                    case 2:
                        do
                        {
                            selection = ForceLegalInput(
                                " Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :",
                                "Lütfen geçerli bir sayı girin !",
                                true);
                        } while (selection < 1 || selection > 5);
                        currentSize = (size)selection;
                        break;
                    case 3:
                        id = ForceLegalInput("Kişi Seçiniz                                    :", 
                            "Lütfen geçerli bir sayı girin !", true);
                        break;
                    default:
                        break;
                }
            }
            //  If key found in team Dictionary
            if(Team.team.ContainsKey(id))
            {
                ToDo.cardList.Add(new Card(title, content, id, currentSize, line.ToDo));
                Console.WriteLine("Kart Eklendi.");
            }   
            else
                Console.WriteLine("Hatalı girişler yaptınız!");
            ;
        }

        //  Called from main loop, to delete selected cards via title.
        public static void Delete()
        {
            int selection = 0;
            do
            {
                // Ask user for title
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                string title = Console.ReadLine();

                // Search on evert line for input title
                foreach (var Card in ToDo.cardList)
                {
                    if(Card.Title == title){
                        ToDo.cardList.Remove(Card);
                        Console.WriteLine("Silme işlemi başarılı");
                        return;
                    }   
                }
                foreach (var Card in InProgress.cardList)
                {
                    if(Card.Title == title)
                    {
                        InProgress.cardList.Remove(Card); 
                        Console.WriteLine("Silme işlemi başarılı");
                        return;
                    }
                        
                }
                foreach (var Card in Done.cardList)
                {
                    if(Card.Title == title)
                    {
                        Done.cardList.Remove(Card); 
                        Console.WriteLine("Silme işlemi başarılı");
                        return; 
                    }
                }

                // If can't find input title in card lists
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                string output = "* Silmeyi sonlandırmak için : (1)" + Environment.NewLine +
                                "* Yeniden denemek için : (2)";
                do
                {   
                    //  force user to enter only one of two options
                    selection = ForceLegalInput(output, "Lütfen geçerli bir sayı giriniz", true);
                    if(selection == 1)  
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                } 
                while (selection < 1 || selection > 2 );
            } 
            while (selection == 2);
        
        }

        //  Print all members to screen
        public static void ListBoard()
        {
            toDo.Print(ToDo.cardList ,"TODO");
            inProgress.Print(InProgress.cardList, "IN PROGRESS");
            done.Print(Done.cardList, "DONE");
        }

        //  Replace card from it's line to preferred new line
        public static void MoveToLine()
        {
            string title= string.Empty;
            bool Replaced = false;
            int selection = 0;
            do
            {   
                // Ask user for title information
                Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                Console.WriteLine("Lütfen kart başlığını yazınız:");

                // Main replace function
                Replaced = Replace(Console.ReadLine());

                // If can't find input title in card lists
                if(!Replaced)
                {
                    string output = "Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız." + Environment.NewLine +
                                    "* İşlemi sonlandırmak için : (1)" + Environment.NewLine +
                                    " * Yeniden denemek için    : (2)";
                    
                    do
                    {
                        selection = ForceLegalInput(output, "Lütfen geçerli bir sayı giriniz", true);
                        if(selection == 1)  
                            Console.WriteLine("Taşımak işlemi sonlandırıldı.");
                    } 
                    while (selection < 1 || selection > 2);
                }
                else{
                    Console.WriteLine("Taşıma İşlemi başarılı.");
                    selection = 0;
                }
            } 
            while (selection == 2);
        }

        // Main replace function
        public static bool Replace(string title)
        {
            for (int i = 0; i < 3; i++)
            {
                List<Card> list = new List<Card>();

                // Determine which list is searching and replace with new card
                switch (i)
                {
                    case 0:
                        list = ToDo.cardList;
                        break;
                    case 1:
                        list = InProgress.cardList;
                        break;
                    case 2:
                        list = Done.cardList;
                        break;
                    default:
                        break;
                }
                //  Search card in buffer
                foreach (var Card in list)
                {
                    if(Card.Title == title)
                    {
                        // print card to screen that user inputted and ask user for select new line
                        int selection = ShowCard(Card);

                        //  If selected same line then return
                        if( selection == (int)Card.LineOf)
                            return true;
                        else
                        {   
                            // indexin 0 based
                            // According to i value in for loop selecting list and make changes
                            switch (i)
                            {   
                                case 0:
                                    ToDo.cardList.Remove(Card);
                                    break;
                                case 1:
                                    InProgress.cardList.Remove(Card);
                                    break;
                                case 2:
                                    Done.cardList.Remove(Card);
                                    break;
                                default:
                                    break;
                            }
                            Card replaced = Card;
                            switch (selection)
                            {
                                case 1:
                                    replaced.LineOf = line.ToDo;
                                    ToDo.cardList.Add(replaced);
                                    break;
                                case 2:
                                    replaced.LineOf = line.InProgress;
                                    InProgress.cardList.Add(replaced);
                                    break;
                                case 3:
                                    replaced.LineOf = line.Done;
                                    Done.cardList.Add(replaced);
                                    break;
                                default:
                                    break;
                            }
                            return true;
                        } 
                    }
                }
            }
            return false;
        }

        // Print card to the screen which is entered from user and ask user for select new line
        public static int ShowCard(Card card)
        {   
            int selection = 0;
            Console.WriteLine("Başlık      : {0}", card.Title);
            Console.WriteLine("İçerik      : {0}", card.Content);
            Console.WriteLine("Atanan Kişi : {0}", card.Id);
            Console.WriteLine("Büyüklük    : {0}", card.SizeOf);
            Console.WriteLine("Line        : {0}", card.LineOf);

            string output ="Lütfen taşımak istediğiniz Line'ı seçiniz: " + Environment.NewLine +
                            "(1) TODO" + Environment.NewLine +
                            "(2) IN PROGRESS" + Environment.NewLine +
                            "(3) DONE"; 
            do
            {
                selection = ForceLegalInput(output, "Lütfen geçerli bir sayı giriniz", true);
            }
            while (selection < 1 || selection > 3);
            return selection;   
        }
    }
}