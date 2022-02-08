using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySeven
{
    internal class Game
    {
        List<MyClassLib.Tank> Tanks;
        public Game()
        {
            Tanks = new List<MyClassLib.Tank>();
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Tanks.Add(new MyClassLib.T34());
                }
                catch (ArgumentNullException) 
                { 
                    Console.WriteLine("Null"); 
                }
                
                
            }

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Tanks.Add(new MyClassLib.Pantera());
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Exception");
                }   
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var ch in Tanks)
            {
                sb.Append(ch);
                sb.Append('\n');
            }
            return sb.ToString();
        }
        public MyClassLib.Tank this[int i]
        {
            get
            {
                return Tanks[i];
            }
        }
        public void Go()
        {
            Console.WriteLine(this);
        }
    }
}
