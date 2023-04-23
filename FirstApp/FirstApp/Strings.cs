using System.Text;
public class Strings
{
    public static void Main1()
    {
        char[] characters = { 'H', 'e', 'l', 'l', 'o' };
        string s = new string(characters);
        Console.WriteLine(s);
        foreach (char c in characters)
        {
            Console.WriteLine(c);
        }

        string s1 = "James", s2 = "Bond", s3 = "007";
        Console.WriteLine("Mr." + s1 + " " + s2 + " " + s3);
        Console.WriteLine($"Mr. {s1} {s2}, Code: {s3}");

        // If a string needs many modification operations, then use string builder.
        StringBuilder sb = new StringBuilder("Hello World");
        for(int i = 0; i < sb.Length; i++)
        {
            Console.Write(sb[i]);
        }
    }
}