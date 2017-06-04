using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_17___MoreExceptions {
    class Program {
        static void Main(string[] args) {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T--> 0) {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
    class Calculator {
        public Calculator() { }
        public int power(int n, int p) {
            if (n < 0 || p < 0)
                throw new Exception("n and p should be non-negative");
            int result;
            result = (int)Math.Pow(n, p);
            return result;
        }
    }
}
