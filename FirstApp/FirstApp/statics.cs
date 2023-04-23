/*
 * Static types behave similar to C++. Static methods can access only static methods and members. Static members cannot be accessed using objects.
 */

static public class StaticClass
{
    public static int staticField;

    public static int Add(int a, int b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main1(string[] args)
    {
        StaticClass.staticField = 1;
        Console.WriteLine("Sum of 1 and 2 is {0}", StaticClass.Add(1, 2));
    }
}