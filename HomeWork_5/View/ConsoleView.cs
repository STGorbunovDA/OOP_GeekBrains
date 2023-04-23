using HomeWork_5.View.Base;

namespace HomeWork_5.View
{
    internal class ConsoleView : IView
    {
        public ConsoleView()
        {
            
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Создать компанию");
            Console.WriteLine("2 - Создать ВУЗ");
            Console.WriteLine("3 - Создать школу");
            Console.WriteLine("0 - Выход");
            Console.WriteLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine($"{message}");
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
    }
}
