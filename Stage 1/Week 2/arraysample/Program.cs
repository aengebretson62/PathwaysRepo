// C# code to linearly search x in arr[]. If x
// is present then return its location, otherwise
// return -1
using System;
 
class GFG {
    public static int mySearch(int[] arrx, int x)
    {
        int N = arrx.Length;
        for (int i = 0; i < N; i++) {
            if (arrx[i] == x)
                return i;
        }
        return -1;
    }
 
    // Driver's code
    public static void Main()
    {
      int[] arr = { 2, 3, 4, 10, 40 };
      int x = 2;
 
        // Function call
       int result = mySearch(arr, x);
       if (result == -1)
            Console.WriteLine(
                "Element is not present in the array");
        else
            Console.WriteLine("Element is in the array at index "
                              + result);
    }
}
