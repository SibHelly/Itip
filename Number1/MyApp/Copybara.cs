using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Copybara
{
    public const string typeAnimal = "Капибара";
    public double weight;
    public double Weight { get { return weight; } set { weight = value; } }
    public int age;
    public int Age { get { return age; } set { age = value; } }
    private string name;
    private string Name { get { return name; } set { name = value; } }
    private string gender;
    private string Gender { get { return gender; } set { gender = value; } }

    public Copybara()//первый конструктор по умолчанию
    {
        name = "Неизвестный";
        gender = "Мужской";
        weight = 40.5;
        age = 5;
    }
    public Copybara(double weight, int age, string name, string gender)
    {//конструктор с параметрами
        this.weight = weight;
        this.age = age;
        this.name = name;
        this.gender = gender;
    }
    public Copybara(string name, double weight)//первый конструктор по умолчанию
    {
        this.name = name;
        this.weight = weight;
        gender = "Мужской";
        age = 5;
    }

    public override string ToString()
    {
        return "Имя - " + this.name + "\nПол - " + this.gender + "\nВес - " + this.weight + "\nВозвраст - " + this.age;
    }

    public void InputInformation()
    {
        this.age = -1;
        this.weight = -1;
        Console.WriteLine("Введите имя капибары");
        string name = Console.ReadLine();
        this.Name = name;
        Console.WriteLine("Введите пол капибары");
        string gender = Console.ReadLine();
        this.Gender = gender;
        while (true)
        {
            Console.WriteLine("Введите возвраст капибары");
            string text = Console.ReadLine();
            if (int.TryParse(text, out age))
            {
                if (age > 0)
                    break;
            }
        }
        while (true)
        {
            Console.WriteLine("Введите вес капибары");
            string text = Console.ReadLine();
            if (double.TryParse(text, out weight))
            {
                if (weight > 0)
                    break;
            }
        }
    }
    public void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }
    public void PrintInformations()
    {
        Console.WriteLine($"Имя - {this.Name}\nПол - {this.Gender}\nВес - {this.Weight}\nВозвраст - {this.Age}");
    }
    public void Swim()
    {
        Console.WriteLine("Капибара плавает");
    }
    public void Scratching()
    {
        Console.WriteLine("Капибаре приятно, когда ее чешут");
    }
    public void GetAdvise()
    {
        Console.WriteLine("Капибара советует хорошо учиться");
    }

    public static void GetHellow()
    {
        Console.WriteLine($"{typeAnimal} машет");
    }

    public static bool operator >(Copybara a, Copybara b)
    {
        return a.weight > b.weight;
    }
    public static bool operator <(Copybara a, Copybara b)
    {
        return a.weight < b.weight;
    }
    public static int operator +(Copybara a, Copybara b)
    {
        return a.Age + b.Age;
    }
}
