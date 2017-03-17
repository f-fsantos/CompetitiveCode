using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        StaircasePrinter(n);
    }
    static void StaircasePrinter(int n) {
        for (int i = 1; i <= n; i++) {
            Console.WriteLine(new String(' ',n-i)+ new String('#',i));
        }
    }
}
