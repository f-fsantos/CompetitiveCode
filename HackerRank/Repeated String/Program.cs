using System;
using System.IO;

namespace Repeated_String
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            int count = 0;
            int extra = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
                    if(i < n % s.Length)
                    {
                        extra++;
                    }
                }
            }
            return count * (n / s.Length) + extra;   
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
