using HomeWork_3.Infrastructure;
using HomeWork_3.Presenters;

namespace HomeWork_3
{
    internal class Program
    {
        static readonly Plane plane = new();
        static void Main()
        {
            PrintMenu();
        }

        static void PrintMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Заполняем фигурами плоскость");
                Console.WriteLine("2 - Печать всех фигур плоскости");
                Console.WriteLine("3 - Добавить фигуру");
                Console.WriteLine("4 - Посчитать периметр у всех фигур");
                Console.WriteLine("5 - Посчитать площадь у всех фигур");
                Console.WriteLine("6 - Посчитать длинну окружности");
                Console.WriteLine("7 - Удалить фигуру из плоскости");
                Console.WriteLine("8 - Показать фигуру по индексу");
                Console.WriteLine("9 - Изменить фигуру");
                Console.WriteLine("10 - Сортировка по площади");
                Console.WriteLine("11 - Выход");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    plane.AddPlaneInFigures();
                    Console.WriteLine("Плоскость заполнена!");
                    Console.ReadLine();
                }
                if (option == "2")
                {
                    Console.Clear();
                    foreach (var figura in plane)
                        Console.WriteLine(figura);
                    Console.ReadLine();
                }
                if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Текущий список животных:");
                    foreach (var item in ListFigures.Figures)
                        Console.WriteLine(item);
                    Console.WriteLine("\nНапишите название фигуры из текущего списка которое хотите создать: ");
                    string name = Console.ReadLine();
                    plane.CreateFigura(name);
                    Console.Clear();
                    Console.WriteLine("Фигура добавлена");
                    Console.ReadLine();
                }
                if (option == "4")
                {
                    Console.Clear();
                    foreach (var perimeter in plane.PerimeterAllFigures())
                        Console.WriteLine($"{perimeter}");
                    Console.ReadLine();
                }
                if (option == "5")
                {
                    Console.Clear();
                    foreach (var area in plane.AreaAllFigures())
                        Console.WriteLine($"{area}");
                    Console.ReadLine();
                }
                if (option == "6")
                {
                    Console.Clear();
                    foreach (var circleLength in plane.GetAllСircleLength())
                        Console.WriteLine($"{circleLength}");
                    Console.ReadLine();
                }
                if (option == "7")
                {
                    bool flag = false;
                    Console.Clear();
                    Console.WriteLine("Введите Index животного (число):");
                    string id = Console.ReadLine();
                    if (int.TryParse(id, out int number))
                        flag = plane.RemoveFigura(Convert.ToInt32(id));
                    else Console.WriteLine("Не удалось распознать Index фигуры, попробуйте еще раз.");
                    if (flag) Console.WriteLine("Фигура удалена!");
                    else Console.WriteLine("Такой фигуры на плоскости нет!");
                    Console.ReadLine();
                }
                if (option == "8")
                {
                    Console.Clear();
                    Console.WriteLine("Введите Index (число) фигуры :");
                    string id = Console.ReadLine();

                    if (int.TryParse(id, out int number))
                        Console.WriteLine(plane[Convert.ToInt32(id)]);
                    else Console.WriteLine("Не удалось распознать Index фигуры, попробуйте еще раз.");
                    Console.ReadLine();
                }
                if (option == "9")
                {
                    bool flag = false;
                    Console.Clear();
                    Console.WriteLine("Введите Index (число) фигуры  которую хотите изменить:");
                    string id = Console.ReadLine();

                    if (int.TryParse(id, out int number))
                        flag = plane.ChangeFigura(Convert.ToInt32(id));
                    else Console.WriteLine("Не удалось распознать Index фигуры, попробуйте еще раз.");
                    if (flag) Console.WriteLine("Фигура изменена!");
                    else Console.WriteLine("ОШИБКА. Такой фигуры на плоскости нет!");
                    Console.ReadLine();
                }
                if (option == "10")
                {
                    Console.Clear();
                    plane.SortFiguresArea();
                    foreach (var animal in plane)
                        Console.WriteLine(animal);
                    Console.ReadLine();
                }
                if (option == "11")
                {
                    return;
                }
            }
        }
    }
}