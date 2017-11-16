using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue
{
    public struct Stats
    {
        double HP;
        double Mana;
        double Attack;
        double Speed;

        public Stats(double h, double m, double a, double s)
        {
            HP = h;
            Mana = m;
            Attack = a;
            Speed = s;
        }

        public void AddModifier(double Mod, string type)//callback???
        {
            switch (type)
            {
                case "HP":
                    HP += Mod;
                    break;
                case "Mana":
                    Mana += Mod;
                    break;
                case "Attack":
                    Attack += Mod;
                    break;
                case "Speed":
                    Speed += Mod;
                    break;
                default:
                    throw new Exception("Wrong type!");
                    
            }
        }
    }
}
