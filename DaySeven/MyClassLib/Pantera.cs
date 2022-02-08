using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySeven.MyClassLib
{
    internal class Pantera : Tank
    {
        public Pantera()
        {
            base.ammo = Services.random.Next(101);
            base.armor = Services.random.Next(101);
            base.agility = Services.random.Next(101);
        }
        public override string ToString()
        {
            return $"Pantera ({base.ToString()})";
        }
    }
}
