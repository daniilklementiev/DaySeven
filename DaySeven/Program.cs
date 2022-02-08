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
            Console.WriteLine(Game[0] ^ Game[1]);
            
        }
    }
}