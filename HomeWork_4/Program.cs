namespace HomeWork_4
{
    internal class Program
    {
        static MyList<double> list;
        static readonly Random rnd = new();
        static void Main()
        {
            list = new();
            PrintMenu();
        }

        private static void PrintMenu()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Добавить элемент в коллекцию");
                Console.WriteLine("2 - Добавить элементы в коллекцию");
                Console.WriteLine("3 - Печать всех элементов колекции");
                Console.WriteLine("4 - Удаление элемента из коллекции по индексу");
                Console.WriteLine("5 - Поиск минимума");
                Console.WriteLine("6 - Поиск максимума");
                Console.WriteLine("7 - Сумма всех элементов массива");
                Console.WriteLine("8 - Произведение всех элементов массива");
                Console.WriteLine("9 - Поиск индекса заданного элемента в массиве");
                Console.WriteLine("10 - Поиск элемента в массиве");
                Console.WriteLine("11 - Получение элемента массива по индексу");
                Console.WriteLine("12 - Задание значения элементу массива с заданным индексом");
                Console.WriteLine("13 - Получить длинну массива");
                Console.WriteLine("14 - Пузырьковая сортировка");
                Console.WriteLine("15 - Сортировка простым выбором");
                Console.WriteLine("16 - Сортировка простыми вставками");
                Console.WriteLine("0 - Выход");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    //list.Add("Яков");
                    //list.Add("Вася");
                    //list.Add("Пупкин");
                    //list.Add("Петров");
                    //list.Add("Дима");
                    //list.Add("Василий");
                    Console.WriteLine("Элемент добавлен.");
                    Console.ReadLine();
                }
                if (option == "2")
                {
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                        list.Add(rnd.Next(3, 15));
                    Console.WriteLine("Элементы добавлены.");
                    Console.ReadLine();
                }
                if (option == "3")
                {
                    int i = 1;
                    Console.Clear();
                    Console.Write("[ ");
                    foreach (var item in list)
                    {
                        if (i == list.Count)
                            Console.Write($"{item}");
                        else Console.Write($"{item}, ");
                        i++;
                    }

                    Console.Write(" ]");
                    Console.ReadLine();
                }
                if (option == "4")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        bool flag = false;
                        Console.WriteLine("Введите Index(число) элемента массива который хотите удалить :");
                        string id = Console.ReadLine();
                        if (int.TryParse(id, out int number))
                            flag = list.Remove(Convert.ToInt32(number));
                        else Console.WriteLine("Не удалось распознать Index элемента массива, попробуйте еще раз.");
                        if (flag) Console.WriteLine("Элемент удален!");
                        else Console.WriteLine("Такого элемнта в коллекции нет!");
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "5")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.Write("Минимальный элемент массива: ");
                        Console.WriteLine(list.SearchingMinimum());
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "6")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.Write("Максимальный элемент массива: ");
                        Console.WriteLine(list.SearchingMaximum());
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "7")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.Write("Сумма всех элементов массива: ");
                        Console.WriteLine(list.SumValueArray());
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "8")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.Write("Произведение всех элементов массива: ");
                        Console.WriteLine(list.MultiplicationValueArray());
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "9")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.WriteLine("Введите элемент массива индекс которого хотите найти :");
                        string id = Console.ReadLine();
                        Console.WriteLine("Индекс искомого элемента: ");
                            Console.WriteLine(list.SearchingIndexArrayValue(id));
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "10")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.WriteLine("Введите элемент массива который хотите найти :");
                        string id = Console.ReadLine();
                        Console.WriteLine(list.Find(id));
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "11")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.WriteLine("Введите Index(число) элемента массива которое хотите найти: ");
                        string id = Console.ReadLine();
                        if (int.TryParse(id, out int number))
                        {
                            Console.WriteLine("Искомый элемент: ");
                            Console.WriteLine(list.GetValueArrayIndex(Convert.ToInt32(number)));    
                        }    
                        else Console.WriteLine("Не удалось распознать Index элемента массива, попробуйте еще раз.");
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "12")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        bool flag;
                        Console.WriteLine("Введите Index(число) элемента массива которому хотите присвоить значение: ");
                        string index = Console.ReadLine();
                        if (int.TryParse(index, out int number))
                        {
                            Console.WriteLine("Введите значение: ");
                            string value = Console.ReadLine();
                            flag = list.InsertElementAtIndex(number, value);
                            if (flag) Console.WriteLine("Удачно.");
                            else Console.WriteLine("Неудачно.");
                        }
                        else Console.WriteLine("Не удалось распознать Index элемента массива, попробуйте еще раз.");
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "13")
                {
                    Console.Clear();
                    if (list.Count > 0)
                    {
                        Console.WriteLine($"Длинна коллекции: {list.Count}");
                    }
                    else Console.WriteLine("Добавь элементы в коллекцию");
                    Console.ReadLine();
                }
                if (option == "14")
                {
                    int i = 1;
                    Console.Clear();
                    Console.Write("[ ");
                    foreach (var item in list.BubbleSort())
                    {
                        if (i == list.Count)
                            Console.Write($"{item}");
                        else Console.Write($"{item}, ");
                        i++;
                    }
                    Console.Write(" ]");
                    Console.ReadLine();

                }
                if (option == "15")
                {
                    int i = 1;
                    Console.Clear();
                    Console.Write("[ ");
                    foreach (var item in list.SortingSimpleChoice())
                    {
                        if (i == list.Count)
                            Console.Write($"{item}");
                        else Console.Write($"{item}, ");
                        i++;
                    }
                    Console.Write(" ]");
                    Console.ReadLine();
                }
                if (option == "16")
                {
                    int i = 1;
                    Console.Clear();
                    Console.Write("[ ");
                    foreach (var item in list.SortingWithSimpleInserts())
                    {
                        if (i == list.Count)
                            Console.Write($"{item}");
                        else Console.Write($"{item}, ");
                        i++;
                    }
                    Console.Write(" ]");
                    Console.ReadLine();
                }
                if (option == "0")
                    return;
            }
        }
    }
}