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

    static void MenuMethod(Rodent rodent)
    {
        int choosed = 0;
        do
        {
            choosed = ChooseMethod();
            switch (choosed)
            {
                case 1:
                    {
                        rodent.Swim();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        rodent.Scratching();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        rodent.GetAdvise();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        if (rodent.ReturnNameClass() == "Хомяк")
                        {
                            Hamster.EatGrains();
                        }
                        if (rodent.ReturnNameClass() == "Капибара")
                        {
                            Copybara.GetHellow();
                        }
                        if (rodent.ReturnNameClass() == "Мышь")
                        {
                            Mouse.WantCheese();
                        }
                        if (rodent.ReturnNameClass() == "Бобр")
                        {
                            Beaver.improveBuilding();
                        }
                        if (rodent.ReturnNameClass() == "Крыса")
                        {
                            Rat.BiteHuman();
                        }
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }

            }
        } while (choosed != 5);
    }
    static int ChooseMenu(Rodent rodent)
    {
        int choosed = 0;
        Console.Clear();
        Console.WriteLine("Выберите действие");
        Console.WriteLine($"1 - Задание параметров объекту {rodent.ReturnNameClass()}");
        Console.WriteLine($"2 - Вывод информации об объекте {rodent.ReturnNameClass()}");
        Console.WriteLine($"3 - Выполнение методов объекта {rodent.ReturnNameClass()}");
        Console.WriteLine($"4 - Вывод имени класса объекта {rodent.ReturnNameClass()}");
        Console.WriteLine("5 - Выход");
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }
    static void Menu(Rodent rodent)
    {
        int choosed = 0;
        do
        {
            choosed = ChooseMenu(rodent);
            switch (choosed)
            {
                case 1:
                    {
                        rodent.InputInformation();
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
                        rodent.PrintNameClass();
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
        Console.WriteLine("6 - Выход");
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }

    static Rodent MenuObject()
    {
        int choosed = 0;
        Rodent rodent = null;
        do
        {
            choosed = ChooseObject();
            switch (choosed)
            {
                case 1:
                    {
                        rodent = new Copybara();
                        choosed = 6;
                        break;
                    }
                case 2:
                    {
                        rodent = new Mouse();
                        choosed = 6;
                        break;
                    }
                case 3:
                    {
                        rodent = new Beaver();
                        choosed = 6;
                        break;
                    }
                case 4:
                    {
                        rodent = new Hamster();
                        choosed = 6;
                        break;
                    }
                case 5:
                    {
                        rodent = new Rat();
                        choosed = 6;
                        break;
                    }

            }
        } while (choosed != 6);
        return rodent;
    }



    public static void Main(string[] args)
    {
        while (true)
        {
            Rodent rodent = MenuObject();
            if (rodent == null)
                break;
            Menu(rodent);
        }
    }
}