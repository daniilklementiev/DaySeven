using System;

namespace DaySeven
{
    class Services
    {
        public static Random random = new Random();
    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            var Game = new Game();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Game[i]);
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine(Game[0] ^ Game[1]);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid Operation");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument Null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}