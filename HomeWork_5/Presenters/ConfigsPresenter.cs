using HomeWork_5.Models;
using HomeWork_5.Models.Base;
using HomeWork_5.Repositories;
using HomeWork_5.View.Base;
using System.Collections.ObjectModel;

namespace HomeWork_5.Presenters
{
    internal class ConfigsPresenter
    {
        private readonly IView view;

        private readonly HumanRepository humanRepository;

        public InformationSystemBase informationSystem;

        private ObservableCollection<Human> HumanColl { get; set; }
        
        public ConfigsPresenter(IView view)
        {
            this.view = view;
            humanRepository = new HumanRepository();
            HumanColl = new ObservableCollection<Human>();
        }

        public void AppRun()
        {
            while (true)
            {
                view.ShowMenuOne();
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

        private void WorkInformationSystem(int chooseHumanColl, string name)
        {
            while (true)
            {
                view.ShowMenuTwo();
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
                if (choose == 1)
                {
                    Console.Clear();
                    foreach (var human in informationSystem)
                        view.ShowMessage($"{human}");
                    Console.ReadLine();
                }
                if (choose == 2)
                {
                    Console.Clear();
                    bool flag = informationSystem.CreateHuman(chooseHumanColl, name);
                    if (flag)
                        view.ShowMessage("Человек успешно добавлен");
                    else view.ShowMessage("Ошибка добавления!");
                    Console.ReadLine();
                }
                if (choose == 3)
                {
                    Console.Clear();
                    informationSystem.SortIdHuman();
                    foreach (var human in informationSystem)
                        view.ShowMessage($"{human}");
                    Console.ReadLine();
                }
                /// И тд.
            }
        }


        private void ProcessInput(int chooseHumanColl)
        {
            string name = string.Empty;
            int countHuman = -1;
            Console.Clear();
            while (true)
            {
                Console.Clear();
                view.ShowMessage("0 - Выход");
                if (chooseHumanColl == 1)
                {
                    view.ShowMessage("Введите название компании: ");
                    name = view.ReadString();
                    view.ShowMessage("Введите кол-во сотрудников компании: ");
                    countHuman = view.ReadChooseInt();
                }
                if (chooseHumanColl == 2)
                {
                    view.ShowMessage("Введите название ВУЗа: ");
                    name = view.ReadString();
                    view.ShowMessage("Введите кол-во студентов ВУЗа: ");
                    countHuman = view.ReadChooseInt();
                }
                if (chooseHumanColl == 3)
                {
                    view.ShowMessage("Введите название Школы: ");
                    name = view.ReadString();
                    view.ShowMessage("Введите кол-во студентов ВУЗа: ");
                    countHuman = view.ReadChooseInt();
                }
                if (name == string.Empty)
                {
                    Console.Clear();
                    view.ShowMessage("Ошибка! Введите название корректно");
                    Console.ReadLine();
                    continue;
                }
                if (countHuman == -1)
                {
                    Console.Clear();
                    view.ShowMessage("Ошибка! Вы ввели не число!");
                    Console.ReadLine();
                    continue;
                }
                if (countHuman == 0 || name == "0")
                    return;
                break;
            }

            //Заполняем коллекцию людьми
            HumanColl = humanRepository.GetHumanPlaneForInformationSystemBase(name, countHuman, chooseHumanColl);
            //Передаём кол-цию в информационную систему для дальнейшей работы
            informationSystem = new(name, HumanColl);
            WorkInformationSystem(chooseHumanColl, name);
        }

       




    }
}
