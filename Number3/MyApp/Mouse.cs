public class Mouse : Rodent
{
    public double Length { get; set; }
    public Mouse()
    {
        // this.Name = "Джерри";
        // this.Age = 1;
        // this.Gender = "Мужской";
        // this.Weight = 1.5;
        // this.Length = 4.7;
        this.InputInformation();
    }
    public override void UseMethods()
    {
        base.UseMethods();
        Mouse.WantCheese();
    }

    public override void InputInformation()
    {
        base.InputInformation();
        while (true)
        {
            Console.WriteLine("Введите длину хвоста мыши");
            string text = Console.ReadLine();
            int length;
            if (int.TryParse(text, out length))
            {
                Length = length;
                if (Length > 0)
                    break;
            }
        }
    }
    public override void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }
    public override string ReturnNameClass()
    {
        return "Мышь";
    }
    public static void WantCheese()
    {
        Console.WriteLine("Мышь очень хочет сыр");
    }
    public override string ToString()
    {
        return "Класс " + this.ReturnNameClass() + "\n" + base.ToString() + "\nДлина хвоста - " + this.Length;
    }
    public override void Swim()
    {
        Console.WriteLine("Я переплыву любой водоем, но не больше озера");
    }
    public override void Scratching()
    {
        Console.WriteLine("Если поймаешь почешишь");
    }
    public override void GetAdvise()
    {
        Console.WriteLine("Мышь советует быть изворотливой и любить сыр");
    }
}