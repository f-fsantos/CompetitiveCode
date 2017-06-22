using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_25___Running_Time___Complexity {
    class Program {
        static void Main(string[] args) {
            int nArgs = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < nArgs; i++) {
                string Prime = "";
                int n = Int32.Parse(Console.ReadLine());

                if (isPrime(n))
                    Prime = "Prime";
                else
                    Prime = "Not prime";
                Console.WriteLine(Prime);
            }
        }
        static bool isPrime(int n) {
            if (n < 2)
                return false;
            if (n < 4)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 3; i * i <= n; i++) {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
