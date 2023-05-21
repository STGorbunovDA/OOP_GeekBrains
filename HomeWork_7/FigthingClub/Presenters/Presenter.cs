using FigthingClub.Infrastructure;
using FigthingClub.View.Base;

namespace FigthingClub.Presenters
{
    internal class Presenter
    {
        private readonly IView view;
        public Presenter(IView view)
        {
            this.view = view;
        }
        public void AppRun()
        {
            while (true)
            {
                view.PrintMenu();
                view.ShowMessage("Выберите пункт меню: ");
                int chooseUser = view.ReadChooseInt();

                if (ValidPrintMenu(chooseUser) == "Break")
                    break;
                else if (ValidPrintMenu(chooseUser) == "StartOver")
                    continue;
               
                ProcessInput(chooseUser);
            }
        }

        private void ProcessInput(int chooseUser)
        {
            if (chooseUser == Constants.NEW_GAME)
            {
                Game game = new Game(view);
                game.StartGame();
            }
            if (chooseUser == Constants.PRINT_RULES)
                view.PrintRules();
            if (chooseUser == Constants.EXIT)
                return;
        }

        private string ValidPrintMenu(int chooseUser)
        {
            if (chooseUser == -1)
            {
                Console.Clear();
                view.ShowMessage("Ошибка! Вы ввели не число!");
                Console.ReadLine();
                return "StartOver";
            }
            if (chooseUser == 0)
                return "Break";
            if (chooseUser < 0 || chooseUser > 3)
            {
                Console.Clear();
                view.ShowMessage("Ошибка! Такого пункта меню не существует.");
                Console.ReadLine();
                return "StartOver";
            }
            return string.Empty;
        }
    }
}
