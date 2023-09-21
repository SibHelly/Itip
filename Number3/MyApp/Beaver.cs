public class Beaver : Rodent
{
    public int DamSize { get; set; }
    public Beaver()
    {
        // this.Name = "Бики";
        // this.Age = 1;
        // this.Gender = "Мужской";
        // this.Weight = 4.3;
        // this.DamSize = 30;
        this.InputInformation();
    }
    public override void UseMethods()
    {
        base.UseMethods();
        Beaver.improveBuilding();
    }
    public override string ReturnNameClass()
    {
        return "Бобр";
    }
    public override void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }

    public override void InputInformation()
    {
        base.InputInformation();
        while (true)
        {
            Console.WriteLine("Введите максимальный размер плотины, которую может построить бобр");
            string text = Console.ReadLine();
            int size;
            if (int.TryParse(text, out size))
            {
                DamSize = size;
                if (DamSize > 0)
                    break;
            }
        }
    }
    public static void improveBuilding()
    {
        Console.WriteLine("Бобр увеличивает плотину");
    }
    public override string ToString()
    {
        return "Класс " + this.ReturnNameClass() + "\n" + base.ToString() + "\nРазмер плотины - " + DamSize;
    }
    public override void Swim()
    {
        Console.WriteLine("Бобр плавает и строит водную плотину");
    }
    public override void Scratching()
    {
        Console.WriteLine("Бобр не хочет, чтоб его чесали");
    }
    public override void GetAdvise()
    {
        Console.WriteLine("Бобр советует становится инженерами");
    }
}