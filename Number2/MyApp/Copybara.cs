sealed class Copybara : Rodent
{
    public int Height { get; set; }
    public Copybara()
    {
        this.Name = "Бобо";
        this.Gender = "Мужской";
        this.Age = 3;
        this.Weight = 5.5;
        this.Height = 76;
    }

    public override void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }
    public override string ReturnNameClass()
    {
        return "Капибара";
    }

    public static void GetHellow()
    {
        Console.WriteLine("Капибара машет лапой");
    }
    public override void InputInformation()
    {
        base.InputInformation();
        while (true)
        {
            Console.WriteLine("Введите высоты капибары");
            string text = Console.ReadLine();
            int height;
            if (int.TryParse(text, out height))
            {
                Height = height;
                if (Height > 0)
                    break;
            }
        }
    }
    public override string ToString()
    {
        return "Класс " + this.ReturnNameClass() + "\n" + base.ToString() + "\nВысота капибары - " + this.Height;
    }

    public override void Swim()
    {
        Console.WriteLine("Капибара плавает");
    }
    public override void Scratching()
    {
        Console.WriteLine("Капибаре приятного, когда ее чешут");
    }
    public override void GetAdvise()
    {
        Console.WriteLine("Капибара советует хорошо учиться");
    }

}