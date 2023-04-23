public class Arrays
{
    // Arrays are reference type variables. So, any change done to the array in the callee function is reflected also in the caller function.
    static void AddTen(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] += 10;
    }
    static void Main2(string[] args)
    {
        int[] arr = new int[5] {1, 2, 3, 4, 5};
        string[] stringArr = new string[2];
        var vArr = new int[] { 1, 2, 3, 4, 5 };

        for(int i = 0; i < vArr.Length; i++)
        {
            Console.WriteLine(vArr[i]);
        }

        foreach(int val in arr)
            Console.WriteLine(val);

        Array.ForEach<int>(arr, (val) => Console.WriteLine(val));

        AddTen(arr);

        Array.ForEach<int>(arr, (val) => Console.WriteLine(val));

        // Multidimensional array
        int[,] arr2d = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 4, 5 } };
        Console.WriteLine(arr2d[0, 1]); // accessing elements

        // Jagged array: An array of arrays. Similar to vector in c++
        int[][] jaggedArray = new int[3][] { new int[]{ 1, 2} , new int[]{ 3, 4, 5}, new int[]{ } }; // Holds 3 single-dimensional arrays.
    }
}

