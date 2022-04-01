using System;

namespace Proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Add Members 
            Team.team.Add(1, "Gryffindor");
            Team.team.Add (2, "Slytherin");
            Team.team.Add (3, "Ravenclaw");
            Team.team.Add(4, "Hufflepuff");

            // Add Cards
            ToDo.cardList.Add(new Card("Harry Potter", "The boy who lived", 0, size.M, line.ToDo));
            InProgress.cardList.Add(new Card("Ron Weasley", "One of fhe fest friend", 0, size.M, line.InProgress));
            InProgress.cardList.Add(new Card("Hermione Granger", "One of fhe fest friend", 0, size.M, line.InProgress));
            Done.cardList.Add(new Card("Lord Voldemort", "The real enemy", 1, size.L, line.Done));
            Done.cardList.Add(new Card("Severus Snape", "Teaching Defence Against the Dark Arts", 1, size.L, line.Done));

            byte selection = 0;
            // Main Loop
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");

                //  Ask what user want to do
                selection = (byte)TaskList.ForceLegalInput(String.Empty, "Lütfen geçerli bir sayı giriniz", false);
                
                switch (selection)
                {
                    case 1:
                        TaskList.ListBoard();
                        break;
                    case 2:
                        TaskList.Insert();
                        break;
                    case 3:
                        TaskList.Delete();
                        break;
                    case 4:
                        TaskList.MoveToLine();
                        break;
                    default:
                        break;
                }
            } 
            while (selection >= 0 && selection <= 5);          
        }
    }
}
