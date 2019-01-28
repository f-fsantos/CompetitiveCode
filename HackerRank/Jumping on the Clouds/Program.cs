using System;
using System.IO;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static int jumpingOnClouds(int n, int[] c)
        {
            int jumps = 0;
            for (int i = 0; i < n-1; i++)
            {
                if (i + 2 >= n )
                {
                    
                    return ++jumps;
                }
                if (c[i + 2] == 1)
                {
                    jumps++;
                }
                else
                {
                    jumps++;
                    i++;
                }
            }
            return jumps;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(n, c);
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

        }
    }
}
