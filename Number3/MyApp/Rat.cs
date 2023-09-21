public class Rat : Rodent
{
    public string Patient { get; set; }
    public Rat()
    {
        // this.Name = "Лариса";
        // this.Age = 1;
        // this.Gender = "Женский";
        // this.Weight = 2;
        // this.Patient = "Да";
        this.InputInformation();
    }

    public override void UseMethods()
    {
        base.UseMethods();
        Rat.BiteHuman();
    }
    public override string ReturnNameClass()
    {
        return "Крыса";
    }
    public override void PrintNameClass()
    {
        Console.WriteLine($"Имя класса - {this.GetType().Name}");
    }

    public static void BiteHuman()
    {
        Console.WriteLine("Крыса кусает человека");
    }

    public override void InputInformation()
    {
        base.InputInformation();
        while (true)
        {
            Console.WriteLine("Опасна ли для человека крыса(Да/Нет/да/нет)");
            string text = Console.ReadLine();
            if (text == "Да" || text == "Нет" || text == "да" || text == "нет")
            {
                Patient = text;
                break;
            }
        }
    }
    public override string ToString()
    {
        return "Класс " + this.ReturnNameClass() + "\n" + base.ToString() + "\nОпасна для человека - " + this.Patient;
    }
    public override void Swim()
    {
        Console.WriteLine("Крыса плавает с помощью хвоста");
    }
    public override void Scratching()
    {
        Console.WriteLine("Крысу лучше не трогать");
    }
    public override void GetAdvise()
    {
        Console.WriteLine("Крыса советует, ее лучше не трогать");
    }

}