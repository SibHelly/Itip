using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Cat : IMammal
{
    public double Weight { get; set; }
    public int Age { get; set; }
    protected string Name { get; set; }
    public string Gender { get; set; }

    public Cat()
    {
        this.InputInformation();
    }

    public static void Walk()
    {
        Console.WriteLine("Я гуляю в три часа ночи и громко бегаю");
    }
    public void UseMethods()
    {
        this.PrintNameClass();
        Console.WriteLine(this.ToString());
        this.Swim();
        this.Scratching();
        this.GetAdvise();
    }
    public virtual void PrintSmallInformation()
    {
        Console.WriteLine($"Класс - {this.ReturnNameClass()}; Имя - {this.Name}");
    }
    public void Swim()
    {
        Console.WriteLine("Я кошка и боюсь воды");
    }
    public void Scratching()
    {
        Console.WriteLine("Я мурлыкаю когда меня гладят");
    }
    public void GetAdvise()
    {
        Console.WriteLine("Кошка советует больше отдыхать");
    }
    public void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }

    public string ReturnNameClass()
    {
        return "Кошка";
    }

    public void InputInformation()
    {
        Age = -1;
        Weight = -1;
        Console.WriteLine($"Введите имя объекта {this.ReturnNameClass()}");
        string name = Console.ReadLine();
        this.Name = name;
        Console.WriteLine("Введите пол объекта");
        string gender = Console.ReadLine();
        this.Gender = gender;
        while (true)
        {
            Console.WriteLine($"Введите возвраст {this.ReturnNameClass()}");
            string text = Console.ReadLine();
            int age;
            if (int.TryParse(text, out age))
            {
                Age = age;
                if (Age > 0)
                    break;
            }
        }
        while (true)
        {
            Console.WriteLine($"Введите вес объекта {this.ReturnNameClass()}");
            string text = Console.ReadLine();
            double weight;
            if (double.TryParse(text, out weight))
            {
                Weight = weight;
                if (Weight > 0)
                    break;
            }
        }
    }

    public override string ToString()
    {
        return "Класс Кошка\nИмя - " + Name + "\nПол - " + Gender + "\nВес - " + Weight + "\nВозвраст - " + Age;
    }
}