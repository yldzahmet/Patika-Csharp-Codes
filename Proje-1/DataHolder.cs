using System;
using System.Collections.Generic;

namespace Proje_1
{
    
    public struct Member
    {
        // Fields
        private string name;
        private string surname;
        private int number;
        public static List<Member> MemberList;

        // Properties
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Number { get => number; set => number = value; }

        // Default Constructor
        public Member(string name, string surname, int number)
        {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }
        // Static Initialize
        static Member()
        {
            MemberList = new List<Member>();
        }
    }
}