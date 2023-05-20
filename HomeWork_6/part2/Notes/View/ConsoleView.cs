using Notes.View.Base;

namespace Notes.View
{
    public class ConsoleView : IView
    {
        public void ShowMenuOne()
        {
            Console.Clear();
            Console.WriteLine("1 - Добавить запись");
            Console.WriteLine("2 - Отредактировать запись");
            Console.WriteLine("3 - Прочитать запись");
            Console.WriteLine("4 - Удалить запись");
            Console.WriteLine("5 - Показать все записи");
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
