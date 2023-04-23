
class DataType
{
    public static void Main1(string[] args)
    {
        int i = Int32.MaxValue;
        Console.WriteLine("The value of i is : {0}, Data type of i is : {1}", i, i.GetType());

        uint ui = (uint)i; // No implicit conversion from signed to unsigned data types

        short s = Int16.MinValue;
        Console.WriteLine("The value of s is : {0}, Data type of s is : {1}", s, s.GetType());

        long l = 314577792900989L;
        Console.WriteLine("The value of l is : {0}", l);

        ulong ul = 32777777776849UL;
        Console.WriteLine("The value of ul is : {0}", ul);
    }
}
