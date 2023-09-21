public abstract class Rodent
{
    public double Weight { get; set; }
    public int Age { get; set; }
    protected string Name { get; set; }
    public string Gender { get; set; }

    public virtual void Swim() { }
    public virtual void Scratching() { }
    public virtual void GetAdvise() { }
    public virtual void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }

    public virtual string ReturnNameClass()
    {
        return "Грызун";
    }

    public virtual void InputInformation()
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
        return "Имя - " + Name + "\nПол - " + Gender + "\nВес - " + Weight + "\nВозвраст - " + Age;
    }
}