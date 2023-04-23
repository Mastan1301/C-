// Delegates are used to pass functions/methods as references to other methods.

public delegate int addDelegate(int a, int b);

class Delegates
{
    public static void Main3(string[] args)
    {
        addDelegate ad = add;
        Console.WriteLine("Sum of {0} and {1} is : {2}", 1, 2, ad(1, 2));
    }

    public static int add(int a, int b)
    {
        return a + b;
    }
}