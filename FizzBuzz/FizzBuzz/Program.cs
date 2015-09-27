using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        string print = "";
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                int max = Int32.Parse(line.Split(' ')[2]);
                int x = Int32.Parse(line.Split(' ')[0]);
                int y = Int32.Parse(line.Split(' ')[1]);
                while (i <= max)
                {
                    if (i % x == 0 && i % y == 0)
                        print += "FB";
                    else if (i % x == 0)
                        print += "F";
                    else if (i % y == 0)
                        print += "B";
                    else
                        print += i;
                    i++;
                    print += " ";
                }
                print = print.Substring(0, print.Length - 1);
                Console.WriteLine(print);
                print = "";
                i = 1;
            }
    }
}