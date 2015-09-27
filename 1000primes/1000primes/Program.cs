using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int i = 3;
        int sum = 2;
        int index = 0;
        bool prime = true;
        List<int> array = new List<int>();
        array.Add(2);
        while (array.Count < 1000)
        {
            while (index < array.Count && prime == true)
            {
                if(i % array[index] == 0)
                    prime = false;
                index++;
            }
            if (prime == true)
            {
                array.Add(i);
                sum += i;
            }
            i++;
            prime = true;
            index = 0;
        }
        Console.WriteLine(sum);
    }
}