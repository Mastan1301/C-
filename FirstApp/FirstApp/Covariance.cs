public class Small
{

}

public class Big : Small
{

}

public class Bigger : Big
{

}

public delegate Small covarDel(Big mc);

public class Program3
{
    public static Big Method1(Big bg)
    {
        Console.WriteLine("Method1");
        return new Big();
    }

    public static Small Method2(Big bg)
    {
        Console.WriteLine("Method2");
        return new Small();
    }

    public static Small Method3(Small sm1)
    {
        Console.WriteLine("Method2");
        return new Small();
    }

    public static void Main(string[] args)
    {
        covarDel del = Method1;
        // Covariance: del expects a return type of Big, but we can still assign it to Small type.
        Small sm1 = del(new Big());
        del = Method2;
        Small sm2 = del(new Big());

        del = Method1;
        del += Method2;
        del += Method3;
        // Contravariance: Method3 requires argument of Small type, but delegate expects a parameter of Big type.
        // Still delegate can be used with Method3
        Small sm = del(new Big());
    }
}

