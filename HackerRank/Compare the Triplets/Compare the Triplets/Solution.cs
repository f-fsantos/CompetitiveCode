using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        string result = TokenComparison(tokens_a0, tokens_b0);
        Console.WriteLine(result);
    }
    static string TokenComparison(string[] tokens_a, string[] tokens_b) {
        // taking the assumptions that the length of tokens_a is always equal to the length of tokens_b
        int result_a = 0, result_b = 0;
        for (int i = 0; i < tokens_a.Length; i++) {
            int tempTokenA = Int32.Parse(tokens_a[i]);
            int tempTokenB = Int32.Parse(tokens_b[i]);
            if (tempTokenA > tempTokenB)
                result_a += 1;
            else if (tempTokenA < tempTokenB)
                result_b += 1;
        }
        return result_a + " " + result_b;
    }
}
