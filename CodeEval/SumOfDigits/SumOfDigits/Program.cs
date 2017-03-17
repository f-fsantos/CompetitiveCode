using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int index = 0;
        int sum = 0;
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                while (index < line.Length)
                {
                    sum += Int32.Parse(line[index].ToString());
                    index++;
                }
                Console.WriteLine(sum);
                index = 0;
                sum = 0;
            }
    }
}