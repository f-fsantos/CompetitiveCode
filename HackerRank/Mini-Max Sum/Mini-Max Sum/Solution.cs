using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    /* A unique solution to this problem
     * Instead of ordering the numbers and only then doing the sum
     * We sum all the numbers and simply remove the highest and lowest
     * Giving us the same result, but more efficiently
     * As we do not have to apply any sorting algorithm
     * */
    static void Main(String[] args) {  
        string input = Console.ReadLine();
        Int64[] array = Array.ConvertAll<string, Int64>(input.Split(' '), Int64.Parse);
        string result = MiniMaxCalculator(array);
        Console.WriteLine(result);
    }
    static string MiniMaxCalculator(Int64[] array) {
        string result = "";
        Int64 sumResult = 0;
        Int64 min = array[0], max = array[0];
        foreach (Int64 i in array) {
            if (i < min)
                min = i;
            if (i > max)
                max = i;
            sumResult += i;
        }
        result = (sumResult - max) + " " + (sumResult - min);
        return result;
    }
}