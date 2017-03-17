using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        double[] result = RatioCalculator(arr, n);
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
        Console.WriteLine(result[2]);
    }
    static double[] RatioCalculator(int[] array, int n) {
        double[] result = new double[3]{0,0,0};
        for (int i = 0; i < n; i++) {
            if (array[i] > 0)
                result[0]++;
            else if (array[i] < 0)
                result[1]++;
            else
                result[2]++;
        }
        result[0] /= n;
        result[1] /= n;
        result[2] /= n;
        return result;
    }
}
