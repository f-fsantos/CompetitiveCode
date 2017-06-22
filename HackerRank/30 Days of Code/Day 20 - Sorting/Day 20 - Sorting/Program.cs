using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20___Sorting {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int numSwaps = 0, tempSwaps = 0;
            do {
                tempSwaps = 0;
                for (int i = 0; i < n - 1; i++) {
                    if(a[i] > a[i+1]) {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        tempSwaps++;
                        numSwaps++;
                    }
                }

            } while (tempSwaps != 0);
            Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Length-1]}");
        }
    }
}
