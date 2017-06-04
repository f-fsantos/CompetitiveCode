using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11___2DArrays {
    class Program {
        static void Main(string[] args) {
            int[][] array = new int[6][];
            int max = 0;
            for (int i = 0; i < 6; i++) {
                array[i] = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Int32.Parse);
            }
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    int k = getHourglass(i, j, array);
                    if (k >= max || (i == 0 && j == 0))
                        max = k;
                }
            }
            Console.WriteLine(max);
        }
        static int getHourglass(int i, int j, int[][] array) {
            int val = 0;
            val = array[i][j] + array[i][j+1] + array[i][j+2] + array[i + 1][j + 1] + array[i+2][j] + array[i + 2][j + 1] + array[i + 2][j + 2];
            return val;
        }
    }
}
