using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3___ConditionalStatements101 {
    class Program {
        static void Main(string[] args) {
            int n = Int32.Parse(Console.ReadLine());

            if (n % 2 == 1)
                Console.WriteLine("Weird");
            else {
                if ((n >= 2 && n <= 5) || n > 20)
                    Console.WriteLine("Not Weird");
                else
                    Console.WriteLine("Weird");
            }
        }
    }
}
