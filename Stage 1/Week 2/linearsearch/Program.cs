// C# code to linearly search x in arr[]. If x
// is present then return its location, otherwise
// return -1
using System;
 
class GFG {
    public static int mySearch(int[] arr, int x)
    {
        int N = arr.Length;
        for (int i = 0; i < N; i++) {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }
 
    // Driver's code
    public static void Main()
    {
      int[] arr = { 2, 3, 4, 10, 40 };
      int x = 10;
 
        // Function call
       int result = mySearch(arr, x);
       if (result == -1)
            Console.WriteLine(
                "Element is not present in array");
        else
            Console.WriteLine("Element is present at index "
                              + result);
    }
}
