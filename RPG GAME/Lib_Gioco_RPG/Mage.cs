using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Gioco_RPG
{
    public class Mage : Character
    {
        int _mana;
        public int Mana { get { return _mana; } set { _mana = value > 100 ? 100 : (value < 0 ? 0 : value); } }
        public Mage(string n) : base(n)
        {
            Mana = rnd.Next(1, 101);
        }
        public override string Stato()
        {
            return Nome + $" ha {Vita} HP e {Mana} mP";
        }
    }
}
