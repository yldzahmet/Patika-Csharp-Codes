using System;

namespace if_else_ternary_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın.");
            }
            else if(time <= 18)
            {
                Console.WriteLine("İyi günler.");

            }
            else
            {
                Console.WriteLine("İyi geceler.");
            }

            string result = time <= 18 ? "İyi günler." : "İyi geceler.";
            Console.WriteLine(result);

            string result2 = time >= 6 ? "İyi günler." : time <= 18 ? "İyi günler." : "İyi geceler.";
        }
    }
}
