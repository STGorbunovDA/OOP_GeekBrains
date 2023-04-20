using HomeWork_2.Infrastructure;
using HomeWork_2.Models.Base;

namespace HomeWork_2
{
    internal class Program
    {
        static readonly Zoo zoo = new Zoo();
        static void Main()
        {
            PrintMenu();
        }
        static void PrintMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Заполнить зоопарк рандомными животными");
                Console.WriteLine("2 - Печать всех животных зоопарка");
                Console.WriteLine("3 - Показать выбранное животное");
                Console.WriteLine("4 - Добавить животное");
                Console.WriteLine("5 - Издать звук животному");
                Console.WriteLine("6 - Издать звук всех животных");
                Console.WriteLine("7 - Удалить животное из зоопарка");
                Console.WriteLine("8 - Выполнить универсальные методы для всех животных");
                Console.WriteLine("9 - Выход");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    zoo.AddRandomAnimalInZoo();
                    Console.WriteLine("Зоопарк заполнен!");
                    Console.ReadLine();
                }
                if (option == "2")
                {
                    Console.Clear();
                    zoo.ShowAllAnimalsZoo();
                    Console.ReadLine();
                }
                if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Введите Id животного (число):");
                    string id = Console.ReadLine();

                    if (int.TryParse(id, out int number))
                        Console.WriteLine(zoo[Convert.ToInt32(id)]);
                       //Console.WriteLine(zoo.ShowAnimal(id));
                    else Console.WriteLine("Не удалось распознать Id животного, попробуйте еще раз.");
                    Console.ReadLine();
                }
                if (option == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Текущий список животных:");
                    foreach (var item in ListAnimals.Animals)
                        Console.WriteLine(item);
                    Console.WriteLine("\nНапишите название животного из текущего списка которое хотите создать: ");
                    string name = Console.ReadLine();
                    zoo.CreateAnimal(name);
                    Console.Clear();
                    Console.WriteLine("Животное добавлено");
                    Console.ReadLine();
                }
                if (option == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Введите Id животного (число):");
                    string id = Console.ReadLine();

                    if (int.TryParse(id, out int number))
                      Console.WriteLine(zoo.VoiceAnimal(id));
                    else Console.WriteLine("Не удалось распознать Id животного, попробуйте еще раз.");
                    Console.ReadLine();
                }
                if (option == "6")
                {
                    Console.Clear();
                    foreach (var voice in zoo.VoicesAnimal())
                        Console.WriteLine($"{voice}");
                    Console.ReadLine();
                }
                if (option == "7")
                {
                    Console.Clear();
                    Console.WriteLine("Введите Id животного (число):");
                    string id = Console.ReadLine();

                    if (int.TryParse(id, out int number))
                        zoo.RemoveAnimal(id);
                    else Console.WriteLine("Не удалось распознать Id животного, попробуйте еще раз.");
                    Console.WriteLine("Животное удалено");
                    Console.ReadLine();
                }
                if (option == "8")
                {
                    Console.Clear();
                    foreach (var universalMethod in zoo.UniversalMethodsAnimal())
                        Console.WriteLine($"{universalMethod}");
                    
                    Console.ReadLine();
                }
                if (option == "9")
                {
                    return;
                }

            }
        }
    }
}
