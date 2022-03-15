using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: \n");
                int sayır1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı " + sayır1);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : "+ ex.Message.ToString());
            }
            
            finally
            {
                Console.WriteLine("İşlem tamamlandı \n");
            }


            try
            {
                //int sayır1 = int.Parse(null);
                int sayı2 = int.Parse("-3000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Hata : "+ ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Hata : "+ ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Hata : "+ ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı \n");
            }
        }
    }
}
