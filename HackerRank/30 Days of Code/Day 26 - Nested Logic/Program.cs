using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_26___Nested_Logic {
    class Program {
        static void Main(string[] args) {
            int[][] date = new int[2][];
            int fine = 0;
            string input = Console.ReadLine();
            date[0] = Array.ConvertAll(input.Split(' '), Int32.Parse);

            input = Console.ReadLine();
            date[1] = Array.ConvertAll(input.Split(' '), Int32.Parse);

            if (date[0][2] > date[1][2]) {
                fine = 10000;
            }
            else if (date[0][2] == date[1][2]) {
                if (date[0][1] > date[1][1]) {
                    fine = (date[0][1] - date[1][1]) * 500;
                }
                else if (date[0][1] == date[1][1])
                    if (date[0][0] > date[1][0]) {
                        fine = (date[0][0] - date[1][0]) * 15;
                    }
            }
            Console.WriteLine(fine);

        }
    }
}
