
using System;

namespace Lib_Gioco_RPG
{
    public class Character
    {
        public string Nome;
        int _vita;
        public int Vita { get { return _vita; } set { _vita = value > 100 ? 100 : (value < 0 ? 0 : value); } }
        protected Random rnd;

        public Character(string nome)
        {
            Nome = nome;
            rnd = new Random();
            Vita = rnd.Next(1, 101);
            Console.WriteLine("he, he, he ,wha");
        }
        public virtual string Stato()
        {
            return Nome + " ha " + $"{Vita}" + " HP";
        }
    }
}
