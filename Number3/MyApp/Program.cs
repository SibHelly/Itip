
using System.Data.Common;

public class Program
{

    static int ChooseMethod()
    {
        Console.Clear();
        int choosed = 0;
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1 - Выполнить метод плавать");
        Console.WriteLine("2 - Выполнить метод почесать");
        Console.WriteLine("3 - Выполнить метод получить совет");
        Console.WriteLine("4 - Выполнить уникальный метод");
        Console.WriteLine("5 - Вернуться назад");
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }

    static void MenuMethod(IMammal rodent)
    {
        int choosed = 0;
        do
        {
            choosed = ChooseMethod();
            switch (choosed)
            {
                case 1:
                    {
                        if (rodent.GetType() == typeof(Cat))
                            ((Cat)rodent).Swim();
                        else
                            ((Rodent)rodent).Swim();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        if (rodent.GetType() == typeof(Cat))
                            ((Cat)rodent).Scratching();
                        else
                            ((Rodent)rodent).Scratching();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        if (rodent.GetType() == typeof(Cat))
                            ((Cat)rodent).GetAdvise();
                        else
                            ((Rodent)rodent).GetAdvise();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        if (rodent.GetType() == typeof(Cat))
                            Cat.Walk();
                        else
                        {
                            if (((Rodent)rodent).ReturnNameClass() == "Хомяк")
                            {
                                Hamster.EatGrains();
                            }
                            if (((Rodent)rodent).ReturnNameClass() == "Капибара")
                            {
                                Copybara.GetHellow();
                            }
                            if (((Rodent)rodent).ReturnNameClass() == "Мышь")
                            {
                                Mouse.WantCheese();
                            }
                            if (((Rodent)rodent).ReturnNameClass() == "Бобр")
                            {
                                Beaver.improveBuilding();
                            }
                            if (((Rodent)rodent).ReturnNameClass() == "Крыса")
                            {
                                Rat.BiteHuman();
                            }
                        }
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }

            }
        } while (choosed != 5);
    }

    static int ChooseMenu(IMammal rodent)
    {
        int choosed = 0;
        Console.Clear();
        if (rodent.GetType() == typeof(Cat))
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine($"1 - Задание параметров объекту {((Cat)rodent).ReturnNameClass()}");
            Console.WriteLine($"2 - Вывод информации об объекте {((Cat)rodent).ReturnNameClass()}");
            Console.WriteLine($"3 - Выполнение методов объекта {((Cat)rodent).ReturnNameClass()}");
            Console.WriteLine($"4 - Вывод имени класса объекта {((Cat)rodent).ReturnNameClass()}");
            Console.WriteLine("5 - Выход");
        }
        else
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine($"1 - Задание параметров объекту {((Rodent)rodent).ReturnNameClass()}");
            Console.WriteLine($"2 - Вывод информации об объекте {((Rodent)rodent).ReturnNameClass()}");
            Console.WriteLine($"3 - Выполнение методов объекта {((Rodent)rodent).ReturnNameClass()}");
            Console.WriteLine($"4 - Вывод имени класса объекта {((Rodent)rodent).ReturnNameClass()}");
            Console.WriteLine("5 - Выход");
        }
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }
    static void Menu(IMammal rodent)
    {
        int choosed = 0;

        do
        {
            choosed = ChooseMenu(rodent);
            switch (choosed)
            {
                case 1:
                    {
                        if (rodent.GetType() == typeof(Cat))
                            ((Cat)rodent).InputInformation();
                        else
                            ((Rodent)rodent).InputInformation();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(rodent.ToString());
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        MenuMethod(rodent);
                        break;
                    }
                case 4:
                    {
                        if (rodent.GetType() == typeof(Cat))
                            ((Cat)rodent).PrintNameClass();
                        else
                            ((Rodent)rodent).PrintNameClass();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }

            }
        } while (choosed != 5);
    }

    static int ChooseObject()
    {
        int choosed = 0;
        Console.Clear();
        Console.WriteLine("Выберите объект");
        Console.WriteLine("1 - Капибара");
        Console.WriteLine("2 - Мышь");
        Console.WriteLine("3 - Бобр");
        Console.WriteLine("4 - Хомяк");
        Console.WriteLine("5 - Крыса");
        Console.WriteLine("6 - Кошка");
        Console.WriteLine("7 - Выход");
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }
    static int ChooseElement(List<IMammal> rodents)
    {
        int choosed = -1;
        while (true)
        {
            Console.Clear();
            if (rodents.Any())
            {

                Console.WriteLine("Выберите обьект для обработки");
                int i = 0;
                foreach (var element in rodents)
                {
                    Console.Write($"{++i} - ");
                    if (element.GetType() == typeof(Cat))
                        ((Cat)element).PrintSmallInformation();
                    else
                        ((Rodent)element).PrintSmallInformation();
                }
                Console.WriteLine($"{rodents.Count() + 1} - Выход");
                Int32.TryParse(Console.ReadLine(), out choosed);
                if (choosed > 0 && choosed <= rodents.Count() + 1)
                    break;
            }
            else
            {
                Console.WriteLine("Список пуст, добавьте элемент");
                break;
            }

        }
        return choosed - 1;
    }

    static void MenuObject(List<IMammal> rodents)
    {
        int choosed = 0;
        do
        {
            choosed = ChooseObject();
            switch (choosed)
            {
                case 1:
                    {
                        rodents.Add(new Copybara());
                        choosed = 7;
                        break;
                    }
                case 2:
                    {
                        rodents.Add(new Mouse());
                        choosed = 7;
                        break;
                    }
                case 3:
                    {
                        rodents.Add(new Beaver());
                        choosed = 7;
                        break;
                    }
                case 4:
                    {
                        rodents.Add(new Hamster());
                        choosed = 7;
                        break;
                    }
                case 5:
                    {
                        rodents.Add(new Rat());
                        choosed = 7;
                        break;
                    }
                case 6:
                    {
                        rodents.Add(new Cat());
                        choosed = 7;
                        break;
                    }
            }
        } while (choosed != 7);
    }

    static int ChooseMainMenu()
    {
        Console.Clear();
        int choosed = 0;
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1 - Добавить элемент в список");
        Console.WriteLine("2 - Выбрать элемент из списка и его обработать");
        Console.WriteLine("3 - Вывод всех объектов из списка");
        Console.WriteLine("4 - Выполнение функции интерфейса");
        Console.WriteLine("5 - Выход");
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }

    static void MainMenu(List<IMammal> rodents)
    {
        int choosed = 0;
        do
        {
            choosed = ChooseMainMenu();
            switch (choosed)
            {
                case 1:
                    {
                        MenuObject(rodents);
                        break;
                    }
                case 2:
                    {
                        int choosedElement = ChooseElement(rodents);
                        if (choosedElement > -2 && rodents.Count >= choosedElement)
                        {
                            if (choosedElement < rodents.Count)
                                Menu(rodents[choosedElement]);
                        }
                        if (choosedElement == -2)
                        {
                            Console.WriteLine("Для возврата в меню нажмите любую клавишу");
                            Console.ReadKey();

                        }
                        break;
                    }
                case 3:
                    {
                        if (rodents.Any())
                            foreach (var element in rodents)
                            {
                                Console.WriteLine(element.ToString() + "\n");
                            }
                        else
                            Console.WriteLine("Список пуст, добавьте элемент");
                        Console.WriteLine("Для возврата в меню нажмите любую клавишу");
                        Console.ReadKey();

                        break;
                    }
                case 4:
                    {
                        int choosedElement = ChooseElement(rodents);
                        Console.Clear();
                        if (choosedElement > -2 && rodents.Count >= choosedElement)
                        {
                            if (choosedElement < rodents.Count)
                            {
                                rodents[choosedElement].UseMethods();
                                Console.WriteLine("Для возврата в меню нажмите любую клавишу");
                                Console.ReadKey();
                            }
                        }
                        if (choosedElement == -2)
                        {
                            Console.WriteLine("Список пуст, добавьте элемент");
                            Console.WriteLine("Для возврата в меню нажмите любую клавишу");
                            Console.ReadKey();
                        }
                        break;
                    }
            }

        }
        while (choosed != 5);
    }

    public static void Main(string[] args)
    {
        List<IMammal> rodents = new List<IMammal>();
        // rodents.Add(new Cat());
        // Console.WriteLine(rodents[0].GetType());
        // ((Cat)rodents[0]).PrintSmallInformation();
        MainMenu(rodents);
    }
}
