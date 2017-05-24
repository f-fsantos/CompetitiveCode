using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7___Arrays {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            string output = "";
            Array.Reverse(arr);
            for (int i = 0; i < n; i++) {
                output += arr[i] + " ";
            }
            output = output.Trim();
            Console.WriteLine(output);
        }
    }
}
