using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6___Let_s_Review {
    class Program {
        static void Main(string[] args) {
            int n = Int32.Parse(Console.ReadLine());

            for (int testCases = 0; testCases < n; testCases++) {
                string s = Console.ReadLine();
                string even = "", odd = "";

                for (int i = 0; i < s.Length; i += 2) {
                    even += s[i];
                    if (!(i == s.Length - 1))
                        odd += s[i + 1];
                }
                Console.WriteLine("{0} {1}", even, odd);
            }
        }
    }
}
