// Func is defined in the System class.
// Func is used to delegate methods which have a non-void return type.
// The last generic type in the angular bracket <> is the output type.

class FuncDelegates
{
    public static void Main4(string[] args)
    {
        Func<int, int, int> funcAdd = Delegates.add;
        Console.WriteLine("Sum of {0} and {1} is : {2}", 1, 2, funcAdd(1, 2));
    }
}