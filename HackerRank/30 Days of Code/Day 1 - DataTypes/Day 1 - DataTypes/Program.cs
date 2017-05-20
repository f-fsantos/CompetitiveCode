using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int secondI = Int32.Parse(Console.ReadLine());
        double secondD = Double.Parse(Console.ReadLine());
        string secondS = Console.ReadLine();

        Console.WriteLine(i + secondI);
        Console.WriteLine("{0:F1}",d + secondD);
        Console.WriteLine(s + secondS);
    }
}