using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9___Recursion {
    class Program {
        static void Main(string[] args) {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
        static int factorial(int n) {
            if (n != 1) {
                return n * factorial(n - 1);
            }
            else
                return n;
        }
    }
}
