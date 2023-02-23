using System;
using Lib_Gioco_RPG;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] Party = new Character[4];
            for (int i = 0; i < Party.Length; i++)
            {
                Console.Write("Inserisci il nome del tuo campione: ");
                string nome = Console.ReadLine();
                Console.Write("Inserisci la classe del tuo campione: ");
                switch (Convert.ToInt32(Console.ReadLine())){
                    case 1:
                        Party[i] = new Mage(nome);
                        break;
                    case 2:
                        Party[i] = new Warrior(nome);
                        break;
                    case 3:
                        Party[i] = new Healer(nome);
                        break;
                    default:
                        Console.WriteLine("Valore invalido. Inserire un valore compresto tra 1 e 3");
                        break;
                }

            }
        }
    }
}
