Jt Jarb
public class Student
{
    private string sex;
    private int age;
    public string Sex { get { return sex; } set { sex = value; } }
    public int Age { get { return age; } set { age = value; } }
    public virtual int Run()
    {
        return Age * 2;
    }
}


public class Jarb : Student
{
    public Jarb(string sex, int age)
    {
        Sex = sex;
        Age = age;
    }

    public override int Run()
    {
        return Age + 3;
    }
}

public class Karn : Student
{
    public Karn(string sex, int age)
    {
        Sex = sex;
        Age = age;
    }

}


public class Program
{
    public static void Main()
    {
        Jarb jarb = new Jarb("M", 20);
        Karn karn = new Karn("M", 22);

        int jarbRun = jarb.Run();
        int karnRun = karn.Run();

        Console.WriteLine($"Jarb age : {jarbRun}");
        Console.WriteLine($"Karn age : {karnRun}");
    }
}