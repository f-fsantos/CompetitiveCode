using System;
using System.IO;

namespace Counting_Valleys
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            int level = 0;
            int valley = 0;
            for (int i = 0; i < n; i++)
            {
                char val = s[i];
                if (val == 'U')
                {
                    if (++level == 0)
                    {
                        valley++;
                    }
                }
                else
                {
                    level--;
                }
            }
            return valley;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
