// We use action delegates for methods which have void return type.

class ActionDelegates
{
    public static void Main5(string[] args)
    {
        Action<int> printDelegate = (int a) => { Console.WriteLine(a); };
        printDelegate(10);
    }
}