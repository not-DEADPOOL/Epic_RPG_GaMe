using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Gioco_RPG
{
    public class Healer:Character
    {
        int _heal;
        public int Heal { get { return _heal; } set { _heal = value > 100 ? 100 : (value < 0 ? 0 : value); } }
        public Healer(string n) : base(n)
        {
            Heal = rnd.Next(1, 101);
        }
        public override string Stato()
        {
            return Nome + $" ha {Vita} HP e {Heal} hP";
        }
    }
}
