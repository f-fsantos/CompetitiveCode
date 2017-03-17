using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        long result = BigSum(arr, n);
        Console.WriteLine(result);
    }
    static long BigSum(int[] array, int n) {
        long result = 0;
        for(int i = 0; i < n; i++) {
            result += array[i];
        }
        return result;
    }
}
