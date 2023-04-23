using HomeWork_5.Models;
using HomeWork_5.View.Base;

namespace HomeWork_5.Presenters
{
    internal class ConfigsPresenter
    {
        private readonly IView view;

        private InformationSystem informationSystem;

        public ConfigsPresenter(IView view, InformationSystem informationSystem)
        {
            this.view = view;
            this.informationSystem = informationSystem;
        }

        private void ProcessInput(int choose)
        {
            Console.Clear();
            switch (choose)
            {
                case 1:
                    {
                        view.ShowMessage("Введите название компании: ");
                        string name = view.ReadString();
                        if (name == string.Empty) 
                        {
                            Console.Clear();
                            view.ShowMessage("Ошибка! Вы не ввели название компании");
                            Console.ReadLine();
                            return;
                        }
                        view.ShowMessage("Введите кол-во сотрудников компании: ");
                        int countWorkerCompany = view.ReadChooseInt();
                        
                        if(countWorkerCompany == -1)
                        {
                            Console.Clear();
                            view.ShowMessage("Ошибка! Вы ввели не число!");
                            Console.ReadLine();
                            return;
                        }
                        break;
                    }
                case 2: { break; }
                case 3: { break; }
            }
        }
        public void AppRun()
        {
            informationSystem = new();
            while (true)
            {
                view.ShowMenu();
                view.ShowMessage("Выберите пункт меню: ");
                int choose = view.ReadChooseInt();
                if (choose == -1)
                {
                    Console.Clear();
                    view.ShowMessage("Ошибка! Вы ввели не число!");
                    Console.ReadLine();
                    continue;
                }
                if (choose == 0)
                    break;
                if (choose < 0 || choose > 4) //TODO продумать кол-во меню
                {
                    Console.Clear();
                    view.ShowMessage("Ошибка! Такого пункта меню не существует.");
                    Console.ReadLine();
                    continue;
                }
                ProcessInput(choose);
            }
        }




    }
}
