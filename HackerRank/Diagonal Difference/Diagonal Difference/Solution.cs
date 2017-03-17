using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++) {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        }
        int result = DiagonalDifferenceCalculator(a,n);
        Console.WriteLine(result);
    }
    static int DiagonalDifferenceCalculator(int[][] array, int n) {
        int result_a = 0, result_b = 0;
        for(int i = 0; i < n; i++) {
            result_a += array[i][i];
            result_b += array[i][n-1 - i];
        }
        return Math.Abs(result_a - result_b);
    }
}
