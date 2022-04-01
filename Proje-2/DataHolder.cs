using System;
using System.Collections.Generic;

namespace Proje_2
{
    public enum size 
    {
        XS = 1,
        S,
        M,
        L,
        XL
    };

    public enum line
    {
        ToDo = 1, 
        InProgress, 
        Done
    };

    public static class Team
    {
        //  (id, title) pairs
        public static Dictionary<int, string> team;

        // Static Constructor
        static Team()
        {
            team = new Dictionary<int, string>();
        }
    }

    public struct Card
    {
        // Fields
        private string title;
        private string content;
        private int id;
        private size sizeOf;
        private line lineOf;
        public static List<Card> cards;


        // Properties
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public int Id { get => id; set => id = value; }
        public size SizeOf { get => sizeOf; set => sizeOf = value; }
        public line LineOf { get => lineOf; set => lineOf = value; }


        // Default Constructor
        public Card(string title, string content, int id, size size, line lineOf) : this()
        {
            Title = title;
            Content = content;
            Id = id;
            SizeOf = size;
            LineOf = lineOf;
        }


        // Static Initialize
        static Card()
        {
            cards = new List<Card>();
        }
    }

    public abstract class Board
    {
        public virtual void Print(List<Card> ownList, string lineName)
        {
            Console.WriteLine("{0} Line", lineName);
            Console.WriteLine("************************");

            foreach (var Card in ownList)
            {
                Console.WriteLine("Başlık      :{0}", Card.Title);
                Console.WriteLine("İçerik      :{0}", Card.Content);
                Console.WriteLine("Atanan Kişi :{0}", Card.Id);
                Console.WriteLine("Büyüklük    :{0}\n - ", Card.SizeOf);
            }
        }
    }

    public class ToDo : Board
    {
        public static List<Card> cardList;
        // Static Constructor
        static ToDo()
        {
            cardList = new List<Card>();
        }
    }

    public class InProgress : Board
    {
        public static List<Card> cardList;
        // Static Constructor
        static InProgress()
        {
            cardList = new List<Card>();
        }
    }

    public class Done : Board
    {
        public static List<Card> cardList;
        // Static Constructor
        static Done()
        {
            cardList = new List<Card>();
        }
    }
}