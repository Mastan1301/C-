/*
 * Predicate delegate represents a method containing a set of criteria and checks whether the passed parameter meets those criteria.
 */

class PredicateDelegates
{
    public static void Main1(string[] args)
    {
        Predicate<string> isUpper = isUpperCase;
        bool good = isUpper("IS THIS GOOD?");
        Console.WriteLine(good);
    }

    static bool isUpperCase(string str)
    {
        return str.Equals(str.ToUpper());
    }
}