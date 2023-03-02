using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Gioco_RPG
{
    public class Round
    {
        static void Round1(Character[] Party,Boss b)
        {
            if (Party == null) return;
            int danno=0;
            for (int i = 0; i < Party.Length; i++)
            {
                danno += Party[i] is Mage ? (Party[i] as Mage).Mana : (Party[i] is Warrior ? (Party[i] as Warrior).Forza : 0);
            }
            b.Vita -= danno;
            if (b.Vita!=0)Round2(Party, b);
        }
        static void Round2(Character[] Party, Boss b)
        {
            if (Party == null) return;
            int vitatotale = 0;
            bool cond = false;
            for (int i = 0; i < Party.Length; i++)
            {
                vitatotale += Party[i].Vita;
                if (Party[i] is Healer) cond = true;//sistemabile con una funzione
            }
            vitatotale -= b.Attacco;
            if (vitatotale < 50 && cond)
            {
                for (int i = 0; i < Party.Length; i++)
                {
                    if (Party[i] is Healer)
                        vitatotale += (Party[i] as Healer).Heal;
                }
                Round3(Party, b,vitatotale);
            }
            else if (vitatotale <= 0)
            {
                Console.WriteLine("HHAFOUJAPFF PERSO!!!!11!!");
                return;
            }
            else
            {
                Console.WriteLine("THe Show must go on11!!!!1!");
                Round3(Party, b,vitatotale);
            }
        }
        static void Round3(Character[] Party, Boss b, int vt)
        {
            if (vt == 0) { Console.WriteLine("Vittoria"); return; }
            else if (b.Vita == 0) { Console.WriteLine("Sconfitta"); return; }
            else Round1(Party, b);
        }
    }
}

