public class Hamster : Rodent
{
    public int NumberGrains { get; set; }
    public Hamster()
    {
        this.Name = "Бибо";
        this.Gender = "Мужской";
        this.Age = 2;
        this.Weight = 0.6;
        this.NumberGrains = 15;
    }

    public override void InputInformation()
    {
        base.InputInformation();
        while (true)
        {
            Console.WriteLine("Введите максимальное количество зерен во рту хоямка");
            string text = Console.ReadLine();
            int number;
            if (int.TryParse(text, out number))
            {
                NumberGrains = number;
                if (NumberGrains >= 0)
                    break;
            }
        }
    }

    public override string ReturnNameClass()
    {
        return "Хомяк";
    }

    public override void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }

    public static void EatGrains()
    {
        Console.WriteLine("Хомяк съел все зерна во рту");
    }
    public override string ToString()
    {
        return "Класс " + this.ReturnNameClass() + "\n" + base.ToString() + "\nКоличество зерен за щеками - " + this.NumberGrains;
    }
    public override void Swim()
    {
        Console.WriteLine("Хомяк не будет плавать, он в клетке живет");
    }
    public override void Scratching()
    {
        Console.WriteLine("Хомяк кусается, когда его чешут");
    }
    public override void GetAdvise()
    {
        Console.WriteLine("Хомяк советует кормить его чаще");
    }


}