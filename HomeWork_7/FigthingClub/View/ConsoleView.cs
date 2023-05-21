using FigthingClub.Models;
using FigthingClub.View.Base;

namespace FigthingClub.View
{
    internal class ConsoleView : IView
    {
        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Игра БОЙЦОВСКИЙ КЛУБ\n");
            Console.WriteLine("1 - Начать игру");
            Console.WriteLine("2 - Правила");
            Console.WriteLine("3 - Выход");
            Console.WriteLine();
        }

        public void PrintRules()
        {
            Console.Clear();
            Console.WriteLine(new Warrior());
            Console.WriteLine(new Dodger());
            Console.WriteLine(new Mage());
            Console.WriteLine(new Archer());
            Console.ReadLine();
        }

        public int ReadChooseInt()
        {
            string option = Console.ReadLine();
            if (int.TryParse(option, out int number))
                return number;
            else return -1;
        }

        public string ReadString()
        {
            string option = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(option))
                return option;
            else return string.Empty;
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
