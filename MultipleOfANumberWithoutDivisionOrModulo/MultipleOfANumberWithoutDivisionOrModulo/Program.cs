using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                // do something with line
                int x = Convert.ToInt32(line.Split(',')[0].ToString());
                int n = Convert.ToInt32(line.Split(',')[1].ToString());
                int b = 0;
                int index = 1;
                while (b < x)
                {
                    b = n * index;
                    index++;
                }
                Console.WriteLine(b);
            }
    }
}