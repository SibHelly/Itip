public class Program
{
    static int Menu()
    {
        int choosed = 0;
        Console.Clear();
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1 - Задание параметров капибаре");
        Console.WriteLine("2 - Вывод информации о капибаре");
        Console.WriteLine("3 - Выполнение методов капибары");
        Console.WriteLine("4 - Вывод имени класса капибары");
        Console.WriteLine("5 - Вывести информацию о трех капибарах");
        Console.WriteLine("6 - Сравнить вес всех капибар и узнать общий возвраст капибар");
        Console.WriteLine("7 - Выход");
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }
    static int MenuMethod()
    {
        Console.Clear();
        int choosed = 0;
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1 - Выполнить метод плавать");
        Console.WriteLine("2 - Выполнить метод почесать");
        Console.WriteLine("3 - Выполнить метод получить совет");
        Console.WriteLine("4 - Выполнить статический метод чтения константного поля");
        Console.WriteLine("5 - Вернуться назад");
        Int32.TryParse(Console.ReadLine(), out choosed);
        return choosed;
    }

    static void ChooseMethod(Copybara copybara)
    {
        int choosed = 0;
        do
        {
            choosed = MenuMethod();
            switch (choosed)
            {
                case 1:
                    {
                        copybara.Swim();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        copybara.Scratching();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        copybara.GetAdvise();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Copybara.GetHellow();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }

            }
        } while (choosed != 5);
    }
    public static void Main()
    {
        int choosed;

        Copybara first = new(30, 5, "БИБО", "Мужской");
        Copybara second = new();
        Copybara third = new("БОБО", 30.15);
        do
        {
            choosed = Menu();
            switch (choosed)
            {
                case 1:
                    {
                        first.InputInformation();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        first.PrintInformations();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        ChooseMethod(first);
                        break;
                    }
                case 4:
                    {
                        first.PrintNameClass();
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Первая капибара, ее редактирует пользователь");
                        Console.WriteLine(first.ToString());
                        Console.WriteLine("Вторая капибара");
                        Console.WriteLine(second.ToString());
                        Console.WriteLine("Третья капибара");
                        Console.WriteLine(third.ToString());
                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Сравниваем вес первой и второй капибары");
                        if (first > second)
                            Console.WriteLine("Первая капибара тяжелее второй");
                        else
                            Console.WriteLine("Вторая капибара тяжелее первой");
                        Console.WriteLine("Сравниваем вес первой и третей капибары");
                        if (first > third)
                            Console.WriteLine("Первая капибара тяжелее третей");
                        else
                            Console.WriteLine("Третья капибара тяжелее первой");
                        Console.WriteLine("Сравниваем вес второй и третей капибары");
                        if (second < third)
                            Console.WriteLine("Третья капибара тяжелее второй");
                        else
                            Console.WriteLine("Вторая капибара тяжелее третей");

                        Console.WriteLine($"Общий возвраст капибар: {first + second + third.age}");

                        Console.WriteLine("Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    }
            }
        } while (choosed != 7);
    }
}
