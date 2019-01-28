using System;
using System.Collections.Generic;
using System.IO;

namespace Sock_Merchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int val = ar[i];
                if (!pairs.ContainsKey(val))
                {
                    pairs.Add(val, 1);
                }
                else
                {
                    if (pairs[val] % 2 == 1)
                    {
                        result++;
                    }

                    pairs[val]++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
