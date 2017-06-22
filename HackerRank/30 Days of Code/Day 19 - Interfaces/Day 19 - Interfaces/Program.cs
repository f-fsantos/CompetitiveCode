using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_19___Interfaces {
    class Program {
        static void Main(string[] args) {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
    public interface AdvancedArithmetic {
        int divisorSum(int n);
    }
    class Calculator : AdvancedArithmetic {
        public int divisorSum(int n) {
            int result = 0;
            for(int i = 1; i<=n; i++) {
                if ((n % i) == 0)
                    result += i;
            }

            return result;
        }
    }
}
