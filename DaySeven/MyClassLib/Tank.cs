using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySeven.MyClassLib
{
    internal class Tank
    {
        public int ammo { get; set; }
        public int armor { get; set; }
        public int agility { get; set; }
        public override string ToString()
        {
            return String.Format("Ammo: {0}, Arm: {1}, Agility: {2}", ammo, armor, agility);
        }

        public static string operator ^(Tank c1, Tank c2)
        {
            int advantage1 = 0;
            int advantage2 = 0;
            var sb = new StringBuilder();
            sb.Append($"Бой {c1} с {c2}\n");
            if (c1.ammo > c2.ammo)
            {
                advantage1 += 1;
                sb.Append($"В боезапасе выиграл: {c1}\n");
            }
            else if (c1.ammo == c2.ammo)
            {
                sb.Append($"В боезапасе ничья\n");
            }
            else
            {
                advantage2 += 1;
                sb.Append($"В боезапасе выиграл: {c2}\n");
            }
            //////////////////////////////////////////////
            if (c1.armor > c2.armor)
            {
                advantage1 += 1;
                sb.Append($"В защите выиграл: {c1}\n");
            }
            else if (c1.armor == c2.armor)
            {
                sb.Append($"В защите ничья\n");
            }
            else
            {
                advantage2 += 1;
                sb.Append($"В защите выиграл: {c2}\n");
            }
            ///////////////////////////////////////////////
            if (c1.agility > c2.agility)
            {
                advantage1 += 1;
                sb.Append($"В маневренности выиграл: {c1}\n");
            }
            else if (c1.agility == c2.agility)
            {
                sb.Append($"В маневренности ничья\n");
            }
            else
            {
                advantage2 += 1;
                sb.Append($"В маневренности выиграл: {c2}\n");
            }

            if (advantage1 > advantage2) sb.Append($"Победитель: {c1}\n");
            else if (advantage2 > advantage1) sb.Append($"Победитель: {c2} \n");
            else sb.Append(sb.Append("Tie"));
            return sb.ToString();
            
        }
    }
}
