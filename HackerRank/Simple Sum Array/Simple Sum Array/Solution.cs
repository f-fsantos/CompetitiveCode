using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static int ArraySum(int[] array, int i) {
        int result = 0;
        for (int j = 0; j < i; j++) {
            result += array[j];
        }
        return result;
    }
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int result = ArraySum(arr, n);
        Console.WriteLine(result);
    }


}
