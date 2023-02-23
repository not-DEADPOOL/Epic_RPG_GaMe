using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Gioco_RPG
{
    public class Warrior:Character
    {
        int _forza;
        public int Forza { get { return _forza; } set { _forza = value > 100 ? 100 : (value < 0 ? 0 : value); } }
        public Warrior(string n) : base(n)
        {
            Forza = rnd.Next(1,101);
        }
        public override string Stato()
        {
            return Nome + $" ha {Vita} HP e {Forza} fP";
        }
    }
}
