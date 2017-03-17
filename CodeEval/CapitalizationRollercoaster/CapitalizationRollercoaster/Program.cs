using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool ToUp = true;
        int index = 0;
        string print = "";
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                while (index < line.Length)
                {
                    if (char.IsLetter(line[index]))
                    {
                        if (ToUp)
                        {
                            print += char.ToUpper(line[index]);
                            ToUp = false;
                        }
                        else
                        {
                            print += char.ToLower(line[index]);
                            ToUp = true;
                        }
                    }
                    else
                        print += line[index];
                    index++;
                }
                index = 0;
                System.Console.WriteLine(print);
                print = "";
                ToUp = true;

            }
    }
}