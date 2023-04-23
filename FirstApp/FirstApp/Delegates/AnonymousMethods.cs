public delegate void Print<T>(T arg);

class AnonymousMethods
{
    public static void Main1(string[] args)
    {
        Print<int> printDelegate = delegate(int val) { Console.WriteLine(val); }; // Anonymous method using delegate()
        printDelegate(19);
    }
}