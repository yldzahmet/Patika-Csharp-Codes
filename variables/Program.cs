using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            byte b = 1;         // 1 byte
            sbyte sb = 2;       // 1 byte
            short sh = 15;      // 2 byte
            ushort ush = 15;      // 2 byte


            int i = -5;         // 4 byte
            Int32 i32 = 5;      // 4 byte
            Int64 i64 = 5;      // 8 byte
            uint ui = 5;        // 4 byte positives only
            long l = -4000;     // 8 byte 
            ulong ul = 4000;    // 8 byte positives only
            float f = 0.5f;     // 4 byte
            double doub = 82131231;                 // 8 byte      
            decimal deci = 2131231232312313;        // 16 byte

            char ch = 'a';  // 2 byte
            string str = "Ahmet";

            bool isTrue = false;

            DateTime dt = DateTime.Now;

            object o1 = "objectName";
            object o2 = 'o';
            object o3 = 17;

            string date = String.Format("Today's date is {0}", DateTime.Now);

            int x1 = 15;
            string x2 = "20";
            x1 += int.Parse(x2);

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("HH/mm");
            Console.WriteLine(dateTime2);
        }
    }
}
