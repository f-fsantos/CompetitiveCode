using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day_28___RegEx_Patterns_Databases {
    class Program {
        static void Main(string[] args) {
            List<string> nameList = new List<string>();
            int N = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < N; a0++) {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];

                Regex regex = new Regex("[a-z]+@gmail.com");
                if (regex.IsMatch(emailID)) {
                    nameList.Add(firstName);
                }
            }
            nameList.Sort();
            foreach (string name in nameList)
                Console.WriteLine(name);
        }
    }
}
