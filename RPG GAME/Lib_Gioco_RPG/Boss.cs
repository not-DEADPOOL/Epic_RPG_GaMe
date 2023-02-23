using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Gioco_RPG
{
    class Boss
    {
        public string Nome;
        int _vita;
        public int Vita { get { return _vita; } set { _vita = value > 100 ? 100 : (value < 0 ? 0 : value); } }
        int _attacco;
        public int Attacco { get { return _attacco; } set { _attacco = value > 300 ? 300 : (value < 1 ? 1 : value); } }

        public Boss(string nome, int vita, int attacco)
        {
            Nome = nome;
            Vita = vita;
            Attacco = attacco;
        }
        public string Stato()
        {
            return "Il BOSS " + Nome + " ha " + $"{Vita}" + " HP";
        }
    }
}
