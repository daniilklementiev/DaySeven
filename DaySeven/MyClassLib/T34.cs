using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySeven.MyClassLib
{
    internal class T34 : Tank
    {
        public T34()
        {
            base.ammo = Services.random.Next(101);
            base.armor = Services.random.Next(101);
            base.agility = Services.random.Next(101);
        }
        public override string ToString()
        {
            return $"T34 ({base.ToString()})";
        }
    }
}
