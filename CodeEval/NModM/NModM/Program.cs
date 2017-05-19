using System.IO;
using System.Collections.Generic;
using System;

class Program {
    static void Main(string[] args) {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream) {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                int n = Int32.Parse(line.Split(',')[0]);
                int m = Int32.Parse(line.Split(',')[1]);
                int result;
                int tempResult = n / m;
                result = n - (m * tempResult);
                Console.WriteLine(result);
            }
    }
}